using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GhostMovement : MonoBehaviour
{
    public float speed = 2.0f;
    public Transform[] patrolPoints;
    public Transform[] PrioritizedPoints;
    public float waitTime = 2.0f;
    private float newWaitTime = 10.0f;
    private int currentPointIndex = 0;
    private int PrioritizedPointIndex = 0;
    private bool once = false;

    public GameSceneMusic AudioManager;
    public HolyWater holyWater;
    public Movement movement;
    private void Update()
    {
        //to check which point should the ghost go to
        if (StaticData.TelevisionInRing)
        {
            PrioritizedPointIndex = 0;
        }
        else if (StaticData.RadioInRing)
        {
            PrioritizedPointIndex = 1;
        }

        // ghost patrolling
        if (!movement.isPaused)
        {
            if (!StaticData.TelevisionInRing && !StaticData.RadioInRing)
            {
                if (transform.position != patrolPoints[currentPointIndex].position)
                {
                    if (!holyWater.Stunned)
                        transform.position = Vector2.MoveTowards(transform.position, patrolPoints[currentPointIndex].position, speed * Time.deltaTime);
                }
                else
                {
                    if (once == false)
                    {
                        AudioManager.GhostRoar(AudioManager.Ghost_Roar);
                        StartCoroutine(WaitForCurrent());
                        once = true;
                    }
                }
            }
            else //if alarm ring, ghost priority change
            {
                if (transform.position != PrioritizedPoints[PrioritizedPointIndex].position)
                {
                    if (!holyWater.Stunned)
                        transform.position = Vector2.MoveTowards(transform.position, PrioritizedPoints[PrioritizedPointIndex].position, speed * Time.deltaTime);
                }
                else
                {
                    if (once == false)
                    {
                        StartCoroutine(WaitForPrioritized());
                        once = true;
                    }
                }
            }
        }

    }

    IEnumerator WaitForCurrent()
    {
        yield return new WaitForSeconds(waitTime);
        if (currentPointIndex + 1 < patrolPoints.Length)
        {
            currentPointIndex++;
        }
        else
        {
            currentPointIndex = 0;

        }
        once = false;
    }

    IEnumerator WaitForPrioritized()
    {
        yield return new WaitForSeconds(newWaitTime);
        once = false;
    }

    private void OnDrawGizmos()
    {
        for(int i = 0; i < 5; i++)
            Gizmos.DrawWireSphere(patrolPoints[i].position, 0.5f);
        for (int j = 0; j < 2; j++)
            Gizmos.DrawWireSphere(PrioritizedPoints[j].position, 0.5f);
    }
}
