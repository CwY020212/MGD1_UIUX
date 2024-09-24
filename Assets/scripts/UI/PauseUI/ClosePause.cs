using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePause : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private GameObject MainInGameUI;
    public Movement movement;
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
        if (movement.isPaused)
            movement.isPaused = false;
        else
            movement.isPaused = true;

        PauseMenu.SetActive(false);
        if (!StaticData.isHiding)
        {
            MainInGameUI.SetActive(true);
        }
        StaticData.isPaused = false;
    }
}
