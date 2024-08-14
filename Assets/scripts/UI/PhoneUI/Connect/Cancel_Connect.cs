using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class Cancel_Connect : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private GameObject Radio_Button;
    [SerializeField] private GameObject Television_Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CancelAction()
    {
        StaticData.TimerInWork = false;
        Radio_Button.SetActive(true);
        Television_Button.SetActive(true);
        StaticData.TelevisionInWork = false;
        StaticData.RadioInWork = false;
        StaticData.TimerInWork = false;
        timerText.text = "No Alarm";
    }
}
