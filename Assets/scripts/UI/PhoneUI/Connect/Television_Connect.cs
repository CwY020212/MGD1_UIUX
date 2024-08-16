using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Television_Connect : MonoBehaviour
{
    [SerializeField] private GameObject Radio_Button;
    [SerializeField] private GameObject Television_Button;
    private int minutes;
    private int seconds;

    [SerializeField] private TextMeshProUGUI timerText;

    private void Start()
    {
        timerText.text = "No Alarm";
    }

    private void Update()
    {
        if (StaticData.TimerInWork == true && StaticData.TelevisionInWork != true )
        {
            Radio_Button.SetActive(false);
            Television_Button.SetActive(false);
            //timer
            StaticData.timer -= Time.deltaTime;
            minutes = Mathf.FloorToInt(StaticData.timer / 60);
            seconds = Mathf.FloorToInt(StaticData.timer % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

        if (StaticData.timer <= 0.0f) //after timer has finish counting && reset
        {
            Radio_Button.SetActive(true);
            Television_Button.SetActive(true);
            StaticData.TelevisionInWork = false;
            StaticData.RadioInWork = false;
            StaticData.TimerInWork = false;
            timerText.text = "No Alarm";
            StaticData.timer = StaticData.minutes + StaticData.seconds;
        }
    }
    public void TelevisionControl()
    {
        if (StaticData.TimerInWork != true)
        {
            StaticData.timer = StaticData.minutes + StaticData.seconds;
            StaticData.TimerInWork = true;
            StaticData.TelevisionInWork = true;
        }
    }

}
