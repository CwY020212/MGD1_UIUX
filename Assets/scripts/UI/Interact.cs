using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

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

    [Header("\t PopOuts \t")]
    public GameObject PopOut;
    public TMP_Text PopOut_Text;
    [SerializeField] string[] note_Text;
    public GameObject hidingLight;

    [Header("\t Item PopOuts \t")]
    public GameObject ItemPopOut;
    public TMP_Text Item_text;
    public string[] Item_TextForEditor;

    public Animator ItemsPOpOut_UI_Animator;

    public GameSceneMusic AudioManager;

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
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Items[0]);
                    StartCoroutine(Wait(Item_TextForEditor[0]));
                }
            }

            if (StaticData.Crucifix == false)
            {
                if (Detection.ItemsInRange[1] == true)
                {
                    StaticData.Crucifix = true;
                    StaticData.LineToBeShown = "Crucifix x 1";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Items[1]);
                    StartCoroutine(Wait(Item_TextForEditor[1]));

                }
            }

            if (StaticData.Salt == false)
            {
                if (Detection.ItemsInRange[2] == true)
                {
                    StaticData.Salt = true;
                    StaticData.LineToBeShown = "Salt x 1";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Items[2]);
                    StartCoroutine(Wait(Item_TextForEditor[2]));

                }
            }

            if (StaticData.Pepper == false)
            {
                if (Detection.ItemsInRange[3] == true)
                {
                    StaticData.Pepper = true;
                    StaticData.LineToBeShown = "Pepper x 1";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Items[3]);
                    StartCoroutine(Wait(Item_TextForEditor[3]));

                }
            }

            if (StaticData.Hammer == false)
            {
                if (Detection.ItemsInRange[4] == true)
                {
                    StaticData.Hammer = true;
                    StaticData.LineToBeShown = "Hammer x 1";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Items[4]);
                    StartCoroutine(Wait(Item_TextForEditor[4]));

                }
            }

            if (StaticData.Key1 == false)
            {
                if (Detection.ItemsInRange[5] == true)
                {
                    StaticData.Key1 = true;
                    StaticData.LineToBeShown = "Key1 x 1";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Items[5]);
                    StartCoroutine(Wait(Item_TextForEditor[5]));

                }
            }

            if (StaticData.Key2 == false)
            {
                if (Detection.ItemsInRange[6] == true)
                {
                    StaticData.Key2 = true;
                    StaticData.LineToBeShown = "Key2 x 1";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Items[6]);
                    StartCoroutine(Wait(Item_TextForEditor[6]));

                }
            }

            if (StaticData.Key3 == false)
            {
                if (Detection.ItemsInRange[7] == true)
                {
                    StaticData.Key3 = true;
                    StaticData.LineToBeShown = "Key3 x 1";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Items[7]);
                    StartCoroutine(Wait(Item_TextForEditor[7]));

                }
            }

            if (StaticData.Key4 == false)
            {
                if (Detection.ItemsInRange[8] == true)
                {
                    StaticData.Key4 = true;
                    StaticData.LineToBeShown = "Key4 x 1";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Items[8]);
                    StartCoroutine(Wait(Item_TextForEditor[8]));

                }
            }

            if (StaticData.HiddenKey == false)
            {
                if (Detection.ItemsInRange[9] == true)
                {
                    StaticData.HiddenKey = true;
                    StaticData.LineToBeShown = "Hidden Key x 1";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Items[9]);
                    StartCoroutine(Wait(Item_TextForEditor[9]));

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
                    AudioManager.PlaySFXsound(AudioManager.Connected);
                }
            }
            if (StaticData.Radio == false)
            {
                if (Detection.AbilityInRange[1] == true)
                {
                    StaticData.Radio = true;
                    StaticData.LineToBeShown = "Radio Control Available Now";
                    AudioManager.PlaySFXsound(AudioManager.Connected);
                }
            }
            if (StaticData.Cloak == false)
            {
                if (Detection.AbilityInRange[2] == true)
                {
                    StaticData.Cloak = true;
                    Destroy(Cloak);
                    StaticData.LineToBeShown = "Cloak Available Now";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
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
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Notes[0]);
                    PopOut.SetActive(true);
                    PopOut_Text.text = note_Text[0];
                }
            }
            if (StaticData.Note2 == false)
            {
                if (Detection.NotesInRange[1] == true)
                {
                    StaticData.Note2 = true;
                    StaticData.LineToBeShown = "Note2 x 1 ";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Notes[1]);
                    PopOut.SetActive(true);
                    PopOut_Text.text = note_Text[1];
                }
            }
            if (StaticData.Note3 == false)
            {
                if (Detection.NotesInRange[2] == true)
                {
                    StaticData.Note3 = true;
                    StaticData.LineToBeShown = "Note3 x 1 ";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Notes[2]);
                    PopOut.SetActive(true);
                    PopOut_Text.text = note_Text[2];
                }
            }
            if (StaticData.Note4 == false)
            {
                if (Detection.NotesInRange[3] == true)
                {
                    StaticData.Note4 = true;
                    StaticData.LineToBeShown = "Note4 x 1 ";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Notes[3]);
                    PopOut.SetActive(true);
                    PopOut_Text.text = note_Text[3];
                }
            }
            if (StaticData.Note5 == false)
            {
                if (Detection.NotesInRange[4] == true)
                {
                    StaticData.Note5 = true;
                    StaticData.LineToBeShown = "Note5 x 1 ";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Notes[4]);
                    PopOut.SetActive(true);
                    PopOut_Text.text = note_Text[4];
                }
            }
            if (StaticData.Note6 == false)
            {
                if (Detection.NotesInRange[5] == true)
                {
                    StaticData.Note6 = true;
                    StaticData.LineToBeShown = "Note6 x 1 ";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Notes[5]);
                    PopOut.SetActive(true);
                    PopOut_Text.text = note_Text[5];
                }
            }
            if (StaticData.Note7 == false)
            {
                if (Detection.NotesInRange[6] == true)
                {
                    StaticData.Note7 = true;
                    StaticData.LineToBeShown = "Note7 x 1 ";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Notes[6]);
                    PopOut.SetActive(true);
                    PopOut_Text.text = note_Text[6];
                }
            }

            if (StaticData.Note8 == false)
            {
                if (Detection.NotesInRange[7] == true)
                {
                    StaticData.Note8 = true;
                    StaticData.LineToBeShown = "Note8 x 1 ";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Notes[7]);
                    PopOut.SetActive(true);
                    PopOut_Text.text = note_Text[7];
                }
            }
            if (StaticData.Note9 == false)
            {
                if (Detection.NotesInRange[8] == true)
                {
                    StaticData.Note9 = true;
                    StaticData.LineToBeShown = "Note9 x 1 ";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Notes[8]);
                    PopOut.SetActive(true);
                    PopOut_Text.text = note_Text[8];
                }
            }
            if (StaticData.Note10 == false)
            {
                if (Detection.NotesInRange[9] == true)
                {
                    StaticData.Note10 = true;
                    StaticData.LineToBeShown = "Note10 x 1 ";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Notes[9]);
                    PopOut.SetActive(true);
                    PopOut_Text.text = note_Text[9];
                }
            }
            if (StaticData.Note11 == false)
            {
                if (Detection.NotesInRange[10] == true)
                {
                    StaticData.Note11 = true;
                    StaticData.LineToBeShown = "Note11 x 1 ";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Notes[10]);
                    PopOut.SetActive(true);
                    PopOut_Text.text = note_Text[10];
                }
            }
            if (StaticData.Note12 == false)
            {
                if (Detection.NotesInRange[11] == true)
                {
                    StaticData.Note12 = true;
                    StaticData.LineToBeShown = "Note12 x 1 ";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Notes[11]);
                    PopOut.SetActive(true);
                    PopOut_Text.text = note_Text[11];
                }
            }
            if (StaticData.Note13 == false)
            {
                if (Detection.NotesInRange[12] == true)
                {
                    StaticData.Note13 = true;
                    StaticData.LineToBeShown = "Note13 x 1 ";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Notes[12]);
                    PopOut.SetActive(true);
                    PopOut_Text.text = note_Text[12];
                }
            }
            if (StaticData.Note14 == false)
            {
                if (Detection.NotesInRange[13] == true)
                {
                    StaticData.Note14 = true;
                    StaticData.LineToBeShown = "Note14 x 1 ";
                    AudioManager.PlaySFXsound(AudioManager.PickUp);
                    Destroy(Notes[13]);
                    PopOut.SetActive(true);
                    PopOut_Text.text = note_Text[13];
                }
            }
        }

        //Hide
        if (Clicked == false && Cooldown_Time >= 10.0f)
        {
            if (StaticData.isHiding == true)
            {
                Clicked = true;
                MainUI.SetActive(false);
                Player.SetActive(false);
                HidingCanvas.SetActive(true);
                StaticData.LineToBeShown = "You are now Hiding";
                AudioManager.PlaySFXsound(AudioManager.PickUp);
                hidingLight.SetActive(true);
            }
        }

        //Door Lock
        if (DoorLockInRange[0])
        {
            if (StaticData.Key1)
            {
                Destroy(Doorlock[0]);
                StaticData.LineToBeShown = "Door is unlocked now";
                AudioManager.PlaySFXsound(AudioManager.DoorOpen);
            }
            else
            {
                StaticData.LineToBeShown = "Master Room is locked";
                AudioManager.PlaySFXsound(AudioManager.DoorLock);
            }
        }

        if (DoorLockInRange[1])
        {

            if (StaticData.Key2)
            {
                Destroy(Doorlock[1]);
                StaticData.LineToBeShown = "Door is unlocked now";
                AudioManager.PlaySFXsound(AudioManager.DoorOpen);
            }
            else
            {
                StaticData.LineToBeShown = "Single room is locked";
                AudioManager.PlaySFXsound(AudioManager.DoorLock);
            }
        }

        if (DoorLockInRange[2])
        {
            if (StaticData.Key3)
            {
                Destroy(Doorlock[2]);
                StaticData.LineToBeShown = "Door is unlocked now";
                AudioManager.PlaySFXsound(AudioManager.DoorOpen);
            }
            else
            {
                StaticData.LineToBeShown = "Room is locked";
                AudioManager.PlaySFXsound(AudioManager.DoorLock);
            }
        }

        if (DoorLockInRange[3])
        {
            if (StaticData.Key4)
            {
                Destroy(Doorlock[3]);
                StaticData.LineToBeShown = "Door is unlocked now";
                AudioManager.PlaySFXsound(AudioManager.DoorOpen);
            }
            else
            {
                StaticData.LineToBeShown = "Study Room is locked";
                AudioManager.PlaySFXsound(AudioManager.DoorLock);
            }
        }

        if (DoorLockInRange[4])
        {
            if (StaticData.HiddenKey)
            {
                Destroy(Doorlock[4]);
                StaticData.LineToBeShown = "Door is unlocked now";
                AudioManager.PlaySFXsound(AudioManager.DoorOpen);
            }
            else
            {
                StaticData.LineToBeShown = "Door is locked";
                AudioManager.PlaySFXsound(AudioManager.DoorLock);
            }
        }


    }
    
    public void PopoutClose()
    {
        PopOut.SetActive(false);
    }

    IEnumerator Wait(string text)
    {
        ItemPopOut.SetActive(true);
        Item_text.text = text;
        yield return new WaitForSeconds(3.0f);
        ItemsPOpOut_UI_Animator.SetBool("PopsClose", true);
        yield return new WaitForSeconds(2.0f);
        ItemPopOut.SetActive(false);
    }
}
