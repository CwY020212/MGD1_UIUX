using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Radio_Connect : MonoBehaviour
{
    [SerializeField] private GameObject Radio_Button;
    [SerializeField] private GameObject Television_Button;
    private float timewanted = StaticData.timer;
    private int minutes;
    private int seconds;

    [SerializeField] private TextMeshProUGUI timerText;

    private void Start()
    {
        timerText.text = "No Alarm";
    }

    private void Update()
    {
        if (StaticData.TimerInWork == true && (StaticData.TelevisionInWork != true || StaticData.RadioInWork != true))
        {
            Radio_Button.SetActive(false);
            Television_Button.SetActive(false);
            //timer
            timewanted -= Time.deltaTime;
            minutes = Mathf.FloorToInt(timewanted / 60);
            seconds = Mathf.FloorToInt(timewanted % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

        if (timewanted <= 0.0f) //after timer has finish counting && reset
        {
            Radio_Button.SetActive(true);
            Television_Button.SetActive(true);
            StaticData.TelevisionInWork = false;
            StaticData.RadioInWork = false;
            StaticData.TimerInWork = false;
            timerText.text = "No Alarm";
            timewanted = StaticData.timer;
        }
    }
    public void RadioControl()
    {
        if (StaticData.TimerInWork != true)
        {
            timewanted = StaticData.timer;
            StaticData.TimerInWork = true;
            StaticData.RadioInWork = true;
        }
    }
}
