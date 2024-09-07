using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class Brightness : MonoBehaviour
{
    public GameObject BrightnessAdjust;
    public GameObject FlowChartButton;
    public Light2D light;
    public Slider slider;
    public TMP_Text text;
    private float num;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = StaticData.brightness;
    }

    // Update is called once per frame
    void Update()
    {
        light.intensity = slider.value/100;
        StaticData.brightness = slider.value;
        num = (int)StaticData.brightness;
        text.text = "" + num;
    }
    
    public void BrightnessCheck()
    {
        BrightnessAdjust.SetActive(false);
        FlowChartButton.SetActive(true);
    }
}
