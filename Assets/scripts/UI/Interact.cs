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
    [SerializeField] private GameObject SubIntButton;
    [SerializeField] private GameObject SubIntButton_Cloak;
    [SerializeField] private GameObject Cloak;
    public GameObject[] Items;
    public GameObject[] Notes;  
    public GameObject[] Doorlock;
    public bool[] DoorLockInRange;
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
                StaticData.LineToBeShown = "Hiding Cooldown Finish";
            }
        }

        if(StaticData.GameStage ==2)
        {
            SubIntButton.SetActive(true);
            SubIntButton_Cloak.SetActive(true);
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
                    StaticData.LineToBeShown = "HolyWater x 1";
                    Destroy(Items[0]);
                }
            }

            if (StaticData.Crucifix == false)
            {
                if (Detection.ItemsInRange[1] == true)
                {
                    StaticData.Crucifix = true;
                    StaticData.LineToBeShown = "Crucifix x 1";
                    Destroy(Items[1]);
                }
            }

            if (StaticData.Salt == false)
            {
                if (Detection.ItemsInRange[2] == true)
                {
                    StaticData.Salt = true;
                    StaticData.LineToBeShown = "Salt x 1";
                    Destroy(Items[2]);
                }
            }

            if (StaticData.Pepper == false)
            {
                if (Detection.ItemsInRange[3] == true)
                {
                    StaticData.Pepper = true;
                    StaticData.LineToBeShown = "Pepper x 1";
                    Destroy(Items[3]);
                }
            }

            if (StaticData.Hammer == false)
            {
                if (Detection.ItemsInRange[4] == true)
                {
                    StaticData.Hammer = true;
                    StaticData.LineToBeShown = "Hammer x 1";
                    Destroy(Items[4]);
                }
            }

            if (StaticData.Key1 == false)
            {
                if (Detection.ItemsInRange[5] == true)
                {
                    StaticData.Key1 = true;
                    StaticData.LineToBeShown = "Key1 x 1";
                    Destroy(Items[5]);
                }
            }

            if (StaticData.Key2 == false)
            {
                if (Detection.ItemsInRange[6] == true)
                {
                    StaticData.Key2 = true;
                    StaticData.LineToBeShown = "Key2 x 1";
                    Destroy(Items[6]);
                }
            }

            if (StaticData.Key3 == false)
            {
                if (Detection.ItemsInRange[7] == true)
                {
                    StaticData.Key3 = true;
                    StaticData.LineToBeShown = "Key3 x 1";
                    Destroy(Items[7]);
                }
            }

            if (StaticData.Key4 == false)
            {
                if (Detection.ItemsInRange[8] == true)
                {
                    StaticData.Key4 = true;
                    StaticData.LineToBeShown = "Key4 x 1";
                    Destroy(Items[8]);
                }
            }

            if (StaticData.HiddenKey == false)
            {
                if (Detection.ItemsInRange[9] == true)
                {
                    StaticData.HiddenKey = true;
                    StaticData.LineToBeShown = "Hidden Key x 1";
                    Destroy(Items[9]);
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
                    StaticData.LineToBeShown = "TV Control Available Now";
                }
            }
            if (StaticData.Radio == false)
            {
                if (Detection.AbilityInRange[1] == true)
                {
                    StaticData.Radio = true;
                    StaticData.LineToBeShown = "Radio Control Available Now";
                }
            }
            if (StaticData.Cloak == false)
            {
                if (Detection.AbilityInRange[2] == true)
                {
                    StaticData.Cloak = true;
                    Destroy(Cloak);
                    StaticData.LineToBeShown = "Cloak Available Now";
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
                    StaticData.LineToBeShown = "Note1 x 1 ";
                    Destroy(Notes[0]);
                }
            }
            if (StaticData.Note2 == false)
            {
                if (Detection.NotesInRange[1] == true)
                {
                    StaticData.Note2 = true;
                    StaticData.LineToBeShown = "Note2 x 1 ";
                    Destroy(Notes[1]);
                }
            }
            if (StaticData.Note3 == false)
            {
                if (Detection.NotesInRange[2] == true)
                {
                    StaticData.Note3 = true;
                    StaticData.LineToBeShown = "Note3 x 1 ";
                    Destroy(Notes[2]);
                }
            }
            if (StaticData.Note4 == false)
            {
                if (Detection.NotesInRange[3] == true)
                {
                    StaticData.Note4 = true;
                    StaticData.LineToBeShown = "Note4 x 1 ";
                    Destroy(Notes[3]);
                }
            }
            if (StaticData.Note5 == false)
            {
                if (Detection.NotesInRange[4] == true)
                {
                    StaticData.Note5 = true;
                    StaticData.LineToBeShown = "Note5 x 1 ";
                    Destroy(Notes[4]);
                }
            }
            if (StaticData.Note6 == false)
            {
                if (Detection.NotesInRange[5] == true)
                {
                    StaticData.Note6 = true;
                    StaticData.LineToBeShown = "Note6 x 1 ";
                    Destroy(Notes[5]);
                }
            }
            if (StaticData.Note7 == false)
            {
                if (Detection.NotesInRange[6] == true)
                {
                    StaticData.Note7 = true;
                    StaticData.LineToBeShown = "Note7 x 1 ";
                    Destroy(Notes[6]);
                }
            }

            if (StaticData.Note8 == false)
            {
                if (Detection.NotesInRange[7] == true)
                {
                    StaticData.Note8 = true;
                    StaticData.LineToBeShown = "Note8 x 1 ";
                    Destroy(Notes[7]);
                }
            }
            if (StaticData.Note9 == false)
            {
                if (Detection.NotesInRange[8] == true)
                {
                    StaticData.Note9 = true;
                    StaticData.LineToBeShown = "Note9 x 1 ";
                    Destroy(Notes[8]);
                }
            }
            if (StaticData.Note10 == false)
            {
                if (Detection.NotesInRange[9] == true)
                {
                    StaticData.Note10 = true;
                    StaticData.LineToBeShown = "Note10 x 1 ";
                    Destroy(Notes[9]);
                }
            }
            if (StaticData.Note11 == false)
            {
                if (Detection.NotesInRange[10] == true)
                {
                    StaticData.Note11 = true;
                    StaticData.LineToBeShown = "Note11 x 1 ";
                    Destroy(Notes[10]);
                }
            }
            if (StaticData.Note12 == false)
            {
                if (Detection.NotesInRange[11] == true)
                {
                    StaticData.Note12 = true;
                    StaticData.LineToBeShown = "Note12 x 1 ";
                    Destroy(Notes[11]);
                }
            }
            if (StaticData.Note13 == false)
            {
                if (Detection.NotesInRange[12] == true)
                {
                    StaticData.Note13 = true;
                    StaticData.LineToBeShown = "Note13 x 1 ";
                    Destroy(Notes[12]);
                }
            }
            if (StaticData.Note14 == false)
            {
                if (Detection.NotesInRange[13] == true)
                {
                    StaticData.Note14 = true;
                    StaticData.LineToBeShown = "Note14 x 1 ";
                    Destroy(Notes[13]);
                }
            }
        }

        //Hide & statue
        if (Clicked == false && Cooldown_Time >= 10.0f)
        {
            if (StaticData.isHiding == true)
            {
                Clicked = true;
                MainUI.SetActive(false);
                Player.SetActive(false);
                HidingCanvas.SetActive(true);
                StaticData.LineToBeShown = "You are now Hiding";
            }
        }

        //Door Lock
        if (DoorLockInRange[0])
        {
            if (StaticData.Key1)
            {
                Destroy(Doorlock[0]);
                StaticData.LineToBeShown = "Door is unlocked now";
            }
            else
            {
                StaticData.LineToBeShown = "Door is locked";
            }
        }

        if (DoorLockInRange[1])
        {

            if (StaticData.Key2)
            {
                Destroy(Doorlock[1]);
                StaticData.LineToBeShown = "Door is unlocked now";
            }
            else
            {
                StaticData.LineToBeShown = "Door is locked";
            }
        }

        if (DoorLockInRange[2])
        {
            if (StaticData.Key3)
            {
                Destroy(Doorlock[2]);
                StaticData.LineToBeShown = "Door is unlocked now";
            }
            else
            {
                StaticData.LineToBeShown = "Door is locked";
            }
        }

        if (DoorLockInRange[3])
        {
            if (StaticData.Key4)
            {
                Destroy(Doorlock[3]);
                StaticData.LineToBeShown = "Door is unlocked now";
            }
            else
            {
                StaticData.LineToBeShown = "Door is locked";
            }
        }

        if (DoorLockInRange[4])
        {
            if (StaticData.HiddenKey)
            {
                Destroy(Doorlock[4]);
                StaticData.LineToBeShown = "Door is unlocked now";
            }
            else
            {
                StaticData.LineToBeShown = "Door is locked";
            }
        }


    }
    
}
