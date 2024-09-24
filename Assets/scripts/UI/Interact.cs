using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
    public Detect Detection;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject HidingCanvas;
    [SerializeField] private GameObject MainUI;
    public GameObject SubIntButton;
    public GameObject SubIntButton_Cloak;
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
    public GameObject hidingLight;

    [Header("\t Item PopOuts \t")]
    public GameObject ItemPopOut;
    public TMP_Text Item_text;
    public string[] Item_TextForEditor;

    public Animator ItemsPOpOut_UI_Animator;

    public GameSceneMusic AudioManager;

    public bool FakeWallInRange = false;
    public GameObject FakeWall;
    public GameObject Load;

    public GameObject closebutton;
    // Update is called once per frame
    void Update()
    {
        if(HidingCanvas.activeInHierarchy)
        {
            closebutton.SetActive(true);
        }
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

        {
            if (StaticData.HolyWater)
            {
                Destroy(Items[0]);
            }
            if (StaticData.Crucifix)
            {
                Destroy(Items[1]);
            }
            if (StaticData.Salt)
            {
                Destroy(Items[2]);
            }
            if (StaticData.Pepper)
            {
                Destroy(Items[3]);
            }
            if (StaticData.Hammer)
            {
                Destroy(Items[4]);
            }
            if (StaticData.Key1)
            {
                Destroy(Items[5]);
            }
            if (StaticData.Key2)
            {
                Destroy(Items[6]);
            }
            if (StaticData.Key3)
            {
                Destroy(Items[7]);
            }
            if (StaticData.Key4)
            {
                Destroy(Items[8]);
            }
            if (StaticData.HiddenKey)
            {
                Items[9].SetActive(false);
            }

            //Notes
            if(StaticData.Note1)
            {
                Destroy(Notes[0]);
            }
            if (StaticData.Note2)
            {
                Destroy(Notes[1]);
            }
            if (StaticData.Note3)
            {
                Destroy(Notes[2]);
            }
            if (StaticData.Note4)
            {
                Destroy(Notes[3]);
            }
            if (StaticData.Note5)
            {
                Destroy(Notes[4]);
            }
            if (StaticData.Note6)
            {
                Destroy(Notes[5]);
            }
            if (StaticData.Note7)
            {
                Destroy(Notes[6]);
            }
            if (StaticData.Note8)
            {
                Destroy(Notes[7]);
            }
            if (StaticData.Note9)
            {
                Destroy(Notes[8]);
            }
            if (StaticData.Note10)
            {
                Destroy(Notes[9]);
            }
            if (StaticData.Note11)
            {
                Destroy(Notes[10]);
            }
            if (StaticData.Note12)
            {
                Destroy(Notes[11]);
            }
            if (StaticData.Note13)
            {
                Destroy(Notes[12]);
            }
            if (StaticData.Note14)
            {
                Destroy(Notes[13]);
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
                    Items[9].SetActive(false);
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
                    PopOut_Text.text = "20XX/06/15" +
                "<br>For those who come back. Last Warning" +
                "<br>This house is abandoned, and our only task is done." +
                "<br>Shut your mouth up to the unbelievers." +
                "<br>Burn this note and leave here.";
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
                    PopOut_Text.text = "Name : Savir" +
                "<br>Age : 26" +
                "<br>Sex : F" +
                "<br>Reason : " +
                "<br>   She's just a fucked up piece of shit. " +
                "She was just trying to ruin our lives by winning the trophy using some ugly and annoying black magics" +
                "<br>She deserved to be here.";
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
                    PopOut_Text.text = "200X/04/20" +
                "<br>She is just sitting in front of the TV for whole day. I wonder-/-/-/-/-/-/-/" +
                "<br>I closed the TV just now, and she left." +
                "<br>She even now is trying to learn some racing things from that stupid TV." +
                "That TV is kinda complicated, and she's from outside." +
                "<br>She must be doing some stuff that we can't understand to tell Mark." +
                "<br>Sad Mark.";
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
                    PopOut_Text.text = "200X/05/16" +
                "<br>Now she is eating. Marson told me to leave her to be hungry." +
                "<br>They wanted to do something." +
                "<br>She's getting used to her life now. That's a good news." +
                "She'll know when she was trying to steal our lives, " +
                "the real problems that we've tasted ain't that tasty.";
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
                    PopOut_Text.text = "200X/05/20" +
                "<br>A nice day I see. Jalden is so smart lol." +
                "He can find a place like this that none of us know about here." +
                "<br>Best Place Ever." +
                "<br>I wish to see Mark's face. His face must be funny lol." +
                "Look at his wife now, another naked stupid bitch here." +
                "<br>A stupid woman with a useless man." +
                "<br>Yeah." +
                "<br>Best Place Ever.";
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
                    PopOut_Text.text = "200X/05/22" +
                "<br>Mark just came to here LOLLLLLLLLLLLLLLLLLL" +
                "<br>He was just literally standing inside of the house but not aware of his bitch." +
                "<br>Watching that was so much funniner than taking care of this." +
                "<br>Luckily though, that bitch started to walk around in the house." +
                "Marson had told me that there won't be any place for that bitch to hide herself," +
                "but still, it can be dangerous what if Mark finds out what's happening here." +
                "<br>I'd better tell Claris to make him stay on a position." +
                "<br>A policeman should be fine.";
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
                    PopOut_Text.text = "200X/06/15" +
                "<br>It can be really boring to stay at here, so I get another fantasy thing from her house to here." +
                "<br>But, how comes this motherfucker has such complicated thing in her house, and this is not even about racing." +
                "Jalden said that this must be the secret those motherfuckers've been hiding before." +
                "<br>It is so complicated that I see how they won the racing trophy with some simple steps." +
                "<br>Black magics huh? Yeah." +
                "<br>You shit unbeliever.";
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
                    PopOut_Text.text = "200X/06/17" +
                "<br>Finally! Marson is ready for the work." +
                "<br>Now we are letting that bitch to have her own redemption.";
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
                    PopOut_Text.text = "200X/09/01" +
                "<br>It takes weeks." +
                "<br>It takes /-/weeks." +
                "<br>It takes weeks." +
                "<br>It take-/-/-/s weeks." +
                "<br>It takes weeks." +
                "<br>It takes w/-/-/-/eeks." +
                "<br>It t-/-/-/-akes weeks." +
                "<br>It takes wee-ks." +
                "<br>It tak-/-/-//-es weeks." +
                "<br>I/-t ta/-kes /-//weeks." +
                "<br>I/-/t tak-/es wee/-/--ks." +
                "<br>I-/t/// takes/ wee////ks." +
                "<br>It take'[-0/0s 0--/9--/eeks." +
                "<br>It- /-/-takes/-0/['; wee/-/-ks." +
                "<br>and no-/-/-/w, FINA-/-LLY-/-/-/-/-/-/-/-";
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
                    PopOut_Text.text = "Marson:" +
                "<br>I'm writing this not for other purposes." +
                "<br>I wonder which step was I wrong? Those steps should have not been wrong." +
                "I have done exactly like Claris said though, that woman just will not turn into Penanggal." +
                "<br>I should have made it without hesitation, but it comes out that it seems to be too late." +
                "That woman is 'stopped', from every view. Her time, her body, her blood, her mind, and most likely her soul." +
                "<br>I can't do anything else to that woman already. Maybe we should just stop here before it is too late." +
                "<br>I'm sure that you won't say yes easily, so forgive me only leaving a letter to you." +
                "<br>" +
                "<br>From " +
                "<br>Jalden";
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
                    PopOut_Text.text = "Phone" +
                "<br>Words" +
                "<br>From End" +
                "<br>To Beginning";
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
                    PopOut_Text.text = "Jalden - Lost" +
                "<br>Jack - Lost" +
                "<br>Marson - -/-/-/-/" +
                "<br>Claris - -/--/-/-/-///" +
                "<br>Brekham - Lost" +
                "<br>Srad - ---////-/-/-/" +
                "<br>Monk - ///-/-/-///" +
                "<br>Criss - Lost" +
                "<br>LZY - Lost" +
                "<br>Terr - Lost" +
                "<br>Chekin - /-//-';'-/';;'-/" +
                "<br>Tvon - -/-/-/--/--//" +
                "<br>LWX - ---/-/-/-/-/";
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
                    PopOut_Text.text = "Jack was making these notes. From the amount I can see that he loved to write things." +
                "<br>I'm hiding one of the papers here." +
                "<br>There should always be something left behind." +
                "<br>People." +
                "<br>And that's always because something that someone had done." +
                "<br>The beginning was the reason I am here.";
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
                    PopOut_Text.text = "I love you";
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

        if(FakeWallInRange)
        {
            if (StaticData.Hammer)
            {
                Destroy(FakeWall);
                StaticData.LineToBeShown = "Wall is broken now";
                StartCoroutine(LoadScene());
            }
            else
            {
                StaticData.LineToBeShown = "Havent collected hammer";
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

    IEnumerator LoadScene()
    { 
        Load.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(4);

    }
}
