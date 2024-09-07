using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Experimental.GraphView;

public class Timer_MinuteDropdown : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    private int Choice;
    // Start is called before the first frame update
    void Start()
    {
        dropdown.value = 0;
    }


    public void GetDropDownValue()
    {
        Choice = dropdown.value;


        //Check NeedED!!!!!!!!
        if (Choice == 0)
        {
            StaticData.minutes = 0.0f;
        }
        else if (Choice == 1)
        {
            StaticData.minutes = 60.0f;
        }
        dropdown.value = Choice;
    }
}
