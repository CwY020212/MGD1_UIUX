using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectUI : MonoBehaviour
{
    public Movement movement;
    [SerializeField] private GameObject Connect_UI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnButtonClick()
    {
        if (StaticData.BatteryLife >= 0)
        {
            if (movement.isPaused == true)
            {
                Connect_UI.SetActive(true);
                StaticData.BatteryLife -= StaticData.BatterPerUse;
            }
        }
    }
}
