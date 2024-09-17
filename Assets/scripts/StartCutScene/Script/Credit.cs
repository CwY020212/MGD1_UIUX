using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit : MonoBehaviour
{
    public GameObject BrightnessAdjust;
    public GameObject CreditImage;
    public GameObject title;
    public GameObject flowchart_button;
    

    void Start()
    {
        StartCoroutine(CreditLoad());
    }

    private void Update()
    {
        if (flowchart_button.activeInHierarchy)
        {
            title.SetActive(true);
        }
    }

    IEnumerator CreditLoad()
    {

        yield return new WaitForSeconds(5.0f);
        BrightnessAdjust.SetActive(true);
        CreditImage.SetActive(false);
    }
}
