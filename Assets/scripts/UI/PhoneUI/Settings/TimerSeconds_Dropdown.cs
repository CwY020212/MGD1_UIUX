using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerSeconds_Dropdown : MonoBehaviour
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

        //Check Needed!!!!!!!
        if (Choice == 1)
        {
            StaticData.seconds = 0.0f;
        }
        else if (Choice == 2)
        {
            StaticData.seconds = 5.0f;
        }
        else if (Choice == 3)
        {
            StaticData.seconds = 10.0f;
        }
        else if (Choice == 4)
        {
            StaticData.seconds = 15.0f;
        }
        else if (Choice == 5)
        {
            StaticData.seconds = 20.0f;
        }
        else if (Choice == 6)
        {
            StaticData.seconds = 25.0f;
        }
        else if (Choice == 7)
        {
            StaticData.seconds = 30.0f;
        }
        else if (Choice == 8)
        {
            StaticData.seconds = 35.0f;
        }
        else if (Choice == 9)
        {
            StaticData.seconds = 40.0f;
        }
        else if (Choice == 10)
        {
            StaticData.seconds = 45.0f;
        }
        else if (Choice == 11)
        {
            StaticData.seconds = 50.0f;
        }
        else if (Choice == 12)
        {
            StaticData.seconds = 55.0f;
        }
    }
}
