using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStage : MonoBehaviour
{
    private bool[] Checklist;
    private int count =0;
    [SerializeField] private GhostMovement Ghost;
    [SerializeField] private GameObject HiddenKey;
    // Start is called before the first frame update
    void Start()
    {
        Checklist = new bool[14];
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (StaticData.Note1 == true)
                Checklist[0] = true;

            if (StaticData.Note2 == true)
                Checklist[1] = true;

            if (StaticData.Note3 == true)
                Checklist[2] = true;

            if (StaticData.Note4 == true)
                Checklist[3] = true;

            if (StaticData.Note5 == true)
                Checklist[4] = true;

            if (StaticData.Note6 == true)
                Checklist[5] = true;

            if (StaticData.Note7 == true)
                Checklist[6] = true;

            if (StaticData.Note8 == true)
                Checklist[7] = true;

            if (StaticData.Note9 == true)
                Checklist[8] = true;

            if (StaticData.Note10 == true)
                Checklist[9] = true;

            if (StaticData.Note11 == true)
                Checklist[10] = true;

            if (StaticData.Note12 == true)
                Checklist[11] = true;

            if (StaticData.Note13 == true)
                Checklist[12] = true;

            if (StaticData.Note14 == true)
                Checklist[13] = true;
        }

        for(int i = 0; i<13;i++)
        {
            if (Checklist[i] == true)
            {
                count++;
            }
        }
        if(count == 13)
        {
            StaticData.GameStage = 2;
        }

        if(StaticData.GameStage ==2)
        {
            HiddenKey.SetActive(true);
            Ghost.speed = 5.0f;
            Ghost.waitTime = 0.5f;
            StaticData.BatteryLife = 10;
            StaticData.LineToBeShown = "New Website in Phone!";
        }
    }
}
