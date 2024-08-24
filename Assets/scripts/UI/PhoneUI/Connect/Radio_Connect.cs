using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Radio_Connect : MonoBehaviour
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
        if (StaticData.TV && StaticData.Radio)
        {
            if (StaticData.isPaused == false)
            {
                if (StaticData.TimerInWork == true && StaticData.RadioInWork != true)
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
                    StaticData.RadioInRing = true;
                    StartCoroutine(Wait());
                    timerText.text = "No Alarm";
                    StaticData.timer = StaticData.minutes + StaticData.seconds;
                    StaticData.LineToBeShown = "The Ghost is distracted!";
                }
            }
        }
    }
    public void RadioControl()
    {
        if (StaticData.TV && StaticData.Radio)
        {
            if (StaticData.TimerInWork != true)
            {
                StaticData.timer = StaticData.minutes + StaticData.seconds;
                StaticData.TimerInWork = true;
                StaticData.RadioInWork = true;
                StaticData.LineToBeShown = "Radio alarm is set";
            }
        }
        else
        {
            StaticData.LineToBeShown = "Haven't Connected to Radio";
        }

        if(StaticData.TV)
        {
            if(!StaticData.Radio)
            {
                StaticData.LineToBeShown = "Radio is not yet connected";
            }
        }
        if (StaticData.Radio)
        {
            if (!StaticData.TV)
            {
                StaticData.LineToBeShown = "TV is not yet connected";
            }
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(15.0f);
        StaticData.RadioInRing = false;
        StaticData.LineToBeShown = "The Ghost started to move again!";
    }
}
