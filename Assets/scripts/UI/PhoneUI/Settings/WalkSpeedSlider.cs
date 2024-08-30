using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WalkSpeedSlider : MonoBehaviour
{
    [SerializeField] private Slider slider;
    public Movement movement;
    [SerializeField] private TextMeshProUGUI WP;
    private int walkspeed;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = movement.movespeed / 1000.0f;
    }

    // Update is called once per frame
    void Update()
    {
        walkspeed = (int)movement.movespeed / 10;
        WP.text = "" + walkspeed ;
    }

    public void GetSliderValue()
    {
        movement.movespeed = slider.value * 500f;
        
    }
}
