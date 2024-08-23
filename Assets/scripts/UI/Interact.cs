using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public Detect Detection;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject HidingCanvas;
    [SerializeField] private GameObject MainUI;
    public bool Clicked = false;
    private const float Cooldown_Period = 10.0f;
    public float Cooldown_Time = Cooldown_Period;
    public Exit Check;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Check.InCoolDown == true)
        {
            Cooldown_Time -= Time.deltaTime;
            if (Cooldown_Time <= 0.0f)
            {
                Check.InCoolDown = false;
                Cooldown_Time = Cooldown_Period;
                StaticData.LineToBeShown = "CoolDown Finish";
            }
        }
    }

    public void OnButtonClick()
    {
        //items
        {
            if (StaticData.HolyWater == false)
            {
                if (Detection.ItemsInRange[0] == true)
                {
                    StaticData.HolyWater = true;
                    StaticData.LineToBeShown = "HolyWater Gotcha";
                }
            }

            if (StaticData.Crucifix == false)
            {
                if (Detection.ItemsInRange[1] == true)
                {
                    StaticData.Crucifix = true;
                }
            }

            if (StaticData.Salt == false)
            {
                if (Detection.ItemsInRange[2] == true)
                {
                    StaticData.Salt = true;
                }
            }

            if (StaticData.Pepper == false)
            {
                if (Detection.ItemsInRange[3] == true)
                {
                    StaticData.Pepper = true;
                }
            }

            if (StaticData.Hammer == false)
            {
                if (Detection.ItemsInRange[4] == true)
                {
                    StaticData.Hammer = true;
                }
            }
        }

        //ability
        {
            if (StaticData.TV == false)
            {
                if (Detection.AbilityInRange[0] == true)
                {
                    StaticData.TV = true;
                }
            }
            if (StaticData.Radio == false)
            {
                if (Detection.AbilityInRange[1] == true)
                {
                    StaticData.Radio = true;
                }
            }
            if (StaticData.Cloak == false)
            {
                if (Detection.AbilityInRange[2] == true)
                {
                    StaticData.Cloak = true;
                }
            }
            if (StaticData.Mimicking == false)
            {
                if (Detection.AbilityInRange[3] == true)
                {
                    StaticData.Mimicking = true;
                }
            }
        }

        //Notes
        {
            if (StaticData.Note1 == false)
            {
                if (Detection.NotesInRange[0] == true)
                {
                    StaticData.Note1 = true;
                }
            }
            if (StaticData.Note2 == false)
            {
                if (Detection.NotesInRange[1] == true)
                {
                    StaticData.Note2 = true;
                }
            }
            if (StaticData.Note3 == false)
            {
                if (Detection.NotesInRange[2] == true)
                {
                    StaticData.Note3 = true;
                    StaticData.LineToBeShown = "Note3 x 1 ";
                }
            }
            if (StaticData.Note4 == false)
            {
                if (Detection.NotesInRange[3] == true)
                {
                    StaticData.Note4 = true;
                    StaticData.LineToBeShown = "Note4 x 1 ";
                }
            }
            if (StaticData.Note5 == false)
            {
                if (Detection.NotesInRange[4] == true)
                {
                    StaticData.Note5 = true;
                    StaticData.LineToBeShown = "Note5 x 1 ";
                }
            }
            if (StaticData.Note6 == false)
            {
                if (Detection.NotesInRange[5] == true)
                {
                    StaticData.Note6 = true;
                }
            }
            if (StaticData.Note7 == false)
            {
                if (Detection.NotesInRange[6] == true)
                {
                    StaticData.Note7 = true;
                }
            }

            if (StaticData.Note8 == false)
            {
                if (Detection.NotesInRange[7] == true)
                {
                    StaticData.Note8 = true;
                }
            }
            if (StaticData.Note9 == false)
            {
                if (Detection.NotesInRange[8] == true)
                {
                    StaticData.Note9 = true;
                }
            }
            if (StaticData.Note10 == false)
            {
                if (Detection.NotesInRange[9] == true)
                {
                    StaticData.Note10 = true;
                }
            }
            if (StaticData.Note11 == false)
            {
                if (Detection.NotesInRange[10] == true)
                {
                    StaticData.Note11 = true;
                }
            }
            if (StaticData.Note12 == false)
            {
                if (Detection.NotesInRange[11] == true)
                {
                    StaticData.Note12 = true;
                }
            }
            if (StaticData.Note13 == false)
            {
                if (Detection.NotesInRange[12] == true)
                {
                    StaticData.Note13 = true;
                }
            }
            if (StaticData.Note14 == false)
            {
                if (Detection.NotesInRange[13] == true)
                {
                    StaticData.Note14 = true;
                }
            }
        }

        //Hide & statue
        if (Clicked == false && Cooldown_Time >= 10.0f)
        {
            if (StaticData.isHiding == true || StaticData.isStatue == true)
            {
                Clicked = true;
                MainUI.SetActive(false);
                Player.SetActive(false);
                HidingCanvas.SetActive(true);
            }
        }
    }
}
