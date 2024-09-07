using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField] private GameObject Setting_UI;
    [SerializeField] private GameObject CloseSetting;

    public void OnSetting()
    {
        Setting_UI.SetActive(true);
        CloseSetting.SetActive(true);
    }

    public void CloseSettingTab()
    {
        Setting_UI.SetActive(false);
        CloseSetting.SetActive(false);
    }
}
