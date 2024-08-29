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
    private float cooldown_time = 30.0f;
    [SerializeField] private TextMeshProUGUI timerText;

    private void Start()
    {
        timerText.text = "No Alarm";
    }

    private void Update()
    {
        Debug.Log(StaticData.TelevisionInCD);

        if(StaticData.TelevisionInCD)
        {
            cooldown_time -= Time.deltaTime;
        }
        if(cooldown_time<=0)
        {
            StaticData.LineToBeShown = "TV control finish cooldown";
            StaticData.TelevisionInCD = false;
            cooldown_time = 30.0f;
        }

        if (StaticData.TV && StaticData.Radio)
        {
            if (StaticData.isPaused == false)
            {
                if (StaticData.TimerInWork == true && StaticData.TelevisionInWork != true)
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
                    StaticData.TelevisionInRing = true;
                    StartCoroutine(Wait());
                    timerText.text = "No Alarm";
                    StaticData.timer = StaticData.minutes + StaticData.seconds;
                    StaticData.LineToBeShown = "The Ghost is distracted!";

                }
            }
        }
    }
    public void TelevisionControl()
    {
        if (!StaticData.TelevisionInCD)
        {
            if (StaticData.TelevisionConnectionInRange)
            {
                if (StaticData.TV && StaticData.Radio)
                {
                    if (StaticData.TimerInWork != true)
                    {
                        StaticData.timer = StaticData.minutes + StaticData.seconds;
                        StaticData.TimerInWork = true;
                        StaticData.TelevisionInWork = true;
                        StaticData.LineToBeShown = " TV alarm is now set";
                        StaticData.TelevisionInCD = true;
                    }
                }
                else
                {
                    StaticData.LineToBeShown = "Haven't connected to TV";
                }

                if (StaticData.TV)
                {
                    if (!StaticData.Radio)
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
            else
            {
                StaticData.LineToBeShown = "You are not in range now";
            }


        }
        else
        {
            StaticData.LineToBeShown = "TV control is in cooldown";
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(15.0f);
        StaticData.TelevisionInRing = false;
        StaticData.LineToBeShown = "The Ghost started to move again!";
    }
}
