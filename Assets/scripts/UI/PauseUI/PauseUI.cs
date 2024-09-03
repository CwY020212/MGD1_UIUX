using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseUI : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private GameObject MainInGameUI;

    public Movement movement;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenPauseMenu()
    {
        if (movement.isPaused == false)
            movement.isPaused = true;
        else
            movement.isPaused = false;

        if (movement.isPaused)
        {
            PauseMenu.SetActive(true);
            MainInGameUI.SetActive(false);
            StaticData.isPaused = true;
        }
    }
}
