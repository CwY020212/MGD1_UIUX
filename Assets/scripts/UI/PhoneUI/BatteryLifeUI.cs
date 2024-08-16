using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BatteryLifeUI : MonoBehaviour
{
    [SerializeField] private Image Battery;
    [SerializeField] private TextMeshProUGUI BatterLife;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Battery.fillAmount = StaticData.BatteryLife/100f;
        BatterLife.text = "" + StaticData.BatteryLife;
    }
}
