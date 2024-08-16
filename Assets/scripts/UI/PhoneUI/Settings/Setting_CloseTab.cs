using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting_CloseTab : MonoBehaviour
{
    [SerializeField] private GameObject Phone_UI;
    [SerializeField] private GameObject SettingUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CloseSettingUI()
    {
        Phone_UI.SetActive(true);
        SettingUI.SetActive(false);
    }
}
