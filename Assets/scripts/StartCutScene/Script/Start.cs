using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
    public GameObject flowchart;
    public GameObject flowChart_Button;

    public void onButtonClick()
    {
        flowchart.SetActive(true);
        flowChart_Button.SetActive(false);
    }
}
