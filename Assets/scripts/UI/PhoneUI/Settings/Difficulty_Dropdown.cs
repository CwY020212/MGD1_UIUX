using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Difficulty_Dropdown : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private GameObject Ghost_Detect;
    [SerializeField] private GameObject Ghost_Warning;
    private int Choice;

    private const float DetectSizeX = 2.0f; //default
    private const float DetectSizeY = 1.5f; //default
    private float DetectX = DetectSizeX;
    private float DetectY = DetectSizeY;

    private const float WarningSizeX = 15.0f; //default
    private const float WarningSizeY = 4.5f; //default
    private float WarningX = WarningSizeX;
    private float WarningY = WarningSizeY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetDropDownValue()
    {
        Choice = dropdown.value;
        
        //Check Needed!!!!!
        if (StaticData.Difficulty == false)
        {
            if (Choice == 1)// Easy
            {
                StaticData.BatteryLife = 100;
                StaticData.Difficulty = true;
                Ghost_Detect.GetComponent<BoxCollider2D>().size = new Vector2(DetectSizeX,DetectSizeY);
                Ghost_Warning.GetComponent<BoxCollider2D>().size = new Vector2(WarningSizeX, WarningSizeY);
            }
            else if (Choice == 2)// Normal
            {
                DetectX = DetectSizeX + 0.5f;
                DetectY = DetectSizeY + 0.5f;
                WarningX = WarningSizeX - 3.0f;
                WarningY = WarningSizeY - 0.5f;
                StaticData.BatteryLife = 50;
                StaticData.Difficulty = true;
                Ghost_Detect.GetComponent<BoxCollider2D>().size = new Vector2(DetectX, DetectY);
                Ghost_Warning.GetComponent<BoxCollider2D>().size = new Vector2(WarningX, WarningY);
            }
            else if (Choice == 3) // Hard
            {
                DetectX = DetectSizeX + 1.0f;
                DetectY = DetectSizeY + 1.0f;
                WarningX = WarningSizeX - 6.0f;
                WarningY = WarningSizeY - 1.0f;
                StaticData.BatteryLife = 30;
                StaticData.Difficulty = true;
                Ghost_Detect.GetComponent<BoxCollider2D>().size = new Vector2(DetectX, DetectY);
                Ghost_Warning.GetComponent<BoxCollider2D>().size = new Vector2(WarningX, WarningY);
            }
        }


    }
}
