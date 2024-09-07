using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit : MonoBehaviour
{
    public GameObject BrightnessAdjust;
    public GameObject CreditImage;
    

    void Start()
    {
        StartCoroutine(CreditLoad());
    }

    IEnumerator CreditLoad()
    {

        yield return new WaitForSeconds(5.0f);
        BrightnessAdjust.SetActive(true);
        CreditImage.SetActive(false);
    }
}
