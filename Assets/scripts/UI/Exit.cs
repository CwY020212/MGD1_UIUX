using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Exit : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject HidingCanvas;
    [SerializeField] private GameObject MainUI;
    private const float timeWanted = 30.0f; // Hiding Time
    private float timer = timeWanted;
    public Interact Check;
    public bool InCoolDown = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Check.Clicked == true)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0.0f)
        {
            StaticData.isHiding = false;
            Check.Clicked = false;
            Player.SetActive(true);
            HidingCanvas.SetActive(false);
            MainUI.SetActive(true);
            timer = timeWanted;
            InCoolDown = true;
            StaticData.LineToBeShown = "Hiding In Cooldown";
        }
    }

    public void OnButtonClick()
    {
        //exit
        if (InCoolDown != true)
        {
            if (StaticData.isHiding == true)
            {
                StaticData.isHiding = false;
                Check.closebutton.SetActive(false);
                Player.SetActive(true);
                HidingCanvas.SetActive(false);
                MainUI.SetActive(true);
                InCoolDown = true;
                StaticData.LineToBeShown = "Hiding In Cooldown";
                Check.Clicked = false;
                timer = timeWanted;
                InCoolDown = true;
                Check.hidingLight.SetActive(false);
            }
        }

    }
}
