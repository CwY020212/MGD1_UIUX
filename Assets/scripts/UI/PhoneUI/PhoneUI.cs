using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PhoneUI : MonoBehaviour
{
    public GameObject Phone_UI;
    [SerializeField] GameObject DeadPhone_UI;
    [SerializeField] GameObject PhoneImage;
    public GameObject MainInGame_UI;
    public Movement movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(StaticData.BatteryLife<=0)
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
