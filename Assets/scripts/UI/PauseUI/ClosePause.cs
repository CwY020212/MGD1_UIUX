using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePause : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private GameObject MainInGameUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClosePauseMenu()
    {
        PauseMenu.SetActive(false);
        MainInGameUI.SetActive(true);
        StaticData.isPaused = false;
    }
}
