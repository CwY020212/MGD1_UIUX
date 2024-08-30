using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mimicking : MonoBehaviour
{
    [SerializeField] private GameObject Mimicking_Button;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject Ghost;

    private bool isMimick;
    private float timer = 30.0f;

    private void Update()
    {
        if (isMimick)
        {
            timer -= Time.deltaTime;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Mimicking"))
        {
            Mimicking_Button.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mimicking"))
        {
            Mimicking_Button.SetActive(false);
        }
    }

    public void OnMimicking()
    {
        if (isMimick == false)
        {
            Player.gameObject.tag = "Editor Only";
            Player.transform.SetParent(Ghost.transform);
            isMimick = true;
        }
    }
}
