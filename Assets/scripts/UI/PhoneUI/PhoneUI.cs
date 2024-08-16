using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class PhoneUI : MonoBehaviour
{
    public GameObject Phone_UI;
    [SerializeField] private GameObject DeadPhone_UI;
    [SerializeField] private GameObject PhoneImage;
    public GameObject MainInGame_UI;
    public Movement movement;

    [SerializeField] private TextMeshProUGUI Phone_time;
    private float time;
    private int hours;
    private int minutes;
    private int seconds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time +=  Time.deltaTime;
        minutes = Mathf.FloorToInt(time / 60);
        seconds = Mathf.FloorToInt(time % 60);
        hours = minutes / 60;
        Phone_time.text = string.Format("{0:00}:{1:00}", hours,minutes);

        if (StaticData.BatteryLife<=0)
        {
            PhoneImage.SetActive(false);
            DeadPhone_UI.SetActive(true);
        }
    }
    public void OnButtonClick()
    {
        if (movement.isPaused == false)
            movement.isPaused = true;
        else
            movement.isPaused = false;

        if (movement.isPaused == true)
        {
            if (StaticData.BatteryLife >= 0)
            {
                Phone_UI.SetActive(true);
            }
            MainInGame_UI.SetActive(false);
        }
    }
}
