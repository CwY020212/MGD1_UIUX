using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class BrightnessAdjustment : MonoBehaviour
{
    public Slider slider;
    public Light2D Glo_light;
    public TMP_Text brightness_text;

    private float num;
    // Start is called before the first frame update
    void Start()
    {
        Glo_light.intensity += StaticData.brightness/500;
        slider.value = Glo_light.intensity;
    }

    void Update()
    {
        Glo_light.intensity = slider.value;
        num = slider.value * 100;
        num = (int)num;
        brightness_text.text = "" + num;
    }
}
