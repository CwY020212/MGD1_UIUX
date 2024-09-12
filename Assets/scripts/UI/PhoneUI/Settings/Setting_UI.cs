using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting_UI : MonoBehaviour
{
    [SerializeField] private GameObject SettingUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenSetting()
    {
        SettingUI.SetActive(true);
    }
}
