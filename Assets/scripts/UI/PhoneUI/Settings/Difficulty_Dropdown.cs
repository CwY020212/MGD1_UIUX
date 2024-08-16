using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Difficulty_Dropdown : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    private int Choice;

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
            if (Choice == 1)
            {
                StaticData.BatteryLife = 100;
                StaticData.Difficulty = true;
            }
            else if (Choice == 2)
            {
                StaticData.BatteryLife = 50;
                StaticData.Difficulty = true;
            }
            else if (Choice == 3)
            {
                StaticData.BatteryLife = 30;
                StaticData.Difficulty = true;
            }
        }


    }
}
