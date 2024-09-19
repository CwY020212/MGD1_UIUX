using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStage : MonoBehaviour
{
    private bool[] Checklist;
    [SerializeField] private GhostMovement Ghost;
    [SerializeField] private GameObject HiddenKey;
    [SerializeField] private GameObject Cloak;

    public GameSceneMusic AudioManager;

    public bool shown = false;
    public Movement movement;

    [Header("\t Canvas \t")]
    public GameObject GameCheckCanvas;
    public GameObject Player;
    public GameObject PhoneUI;
    public GameObject NotesUI;
    public GameObject MainUI;
    public GameObject HUD;
    public GameObject PopOut;
    public GameObject doubleCheck;
    public Interact interact;

    public TMP_Text double_Text;
    public string doubleCheck_Text;

    public bool YesCheck = false;
    public bool NoCheck = false;

    [Header("\t Check Again \t")]
    public GameObject Wall;
    public GameObject Trigger;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Checklist = new bool[14];
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (StaticData.Note1 == true)
                Checklist[0] = true;

            if (StaticData.Note2 == true)
                Checklist[1] = true;

            if (StaticData.Note3 == true)
                Checklist[2] = true;

            if (StaticData.Note4 == true)
                Checklist[3] = true;

            if (StaticData.Note5 == true)
                Checklist[4] = true;

            if (StaticData.Note6 == true)
                Checklist[5] = true;

            if (StaticData.Note7 == true)
                Checklist[6] = true;

            if (StaticData.Note8 == true)
                Checklist[7] = true;

            if (StaticData.Note9 == true)
                Checklist[8] = true;

            if (StaticData.Note10 == true)
                Checklist[9] = true;

            if (StaticData.Note11 == true)
                Checklist[10] = true;

            if (StaticData.Note12 == true)
                Checklist[11] = true;

            if (StaticData.Note13 == true)
                Checklist[12] = true;

            if (StaticData.Note14 == true)
                Checklist[13] = true;   
        }
        if (Checklist[0]&& Checklist[1] && Checklist[2] && Checklist[3] && Checklist[4] && Checklist[5] && Checklist[6] && Checklist[7] && Checklist[8] && Checklist[9] && Checklist[10] && Checklist[11] && Checklist[12] && Checklist[13])
        {
            StaticData.GameStage = 2;
        }

        if(StaticData.GameStage ==2 &&shown == false)
        {
            MainUI.SetActive(false);
            HUD.SetActive(false);
            PopOut.SetActive(false);
            Ghost.speed = 0.0f;
            shown = true;
            StartCoroutine(Wait());
            
        }   
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3.0f);
        GameCheckCanvas.SetActive(true);
        Player.transform.position = new Vector3(-9, -14, 0);
    }

    public void Yes()
    {
        YesCheck = true;
        doubleCheck.SetActive(true);
        double_Text.text = doubleCheck_Text ;
    }

    public void CheckAgain()
    {
        if (movement.isPaused == true)
            movement.isPaused = false;
        else
            movement.isPaused = true;

        animator.SetBool("StageClosed", true);
        GameCheckCanvas.SetActive(false);
        PhoneUI.SetActive(true);
        NotesUI.SetActive(true);
        Wall.SetActive(true);
        Trigger.SetActive(true);
    }

    public void No()
    {
        NoCheck = true;
        doubleCheck.SetActive(true);
        double_Text.text = "Won't you regret?";
    }

    public void doubleYes()
    {
        if (YesCheck == true)
        {
            AudioManager.Clear(AudioManager.Music);
            AudioManager.PlayBackgroundSound(AudioManager.Background_EndStage);
            StaticData.LineToBeShown = "Last Game Stage";
            movement.movespeed = 1200.0f;
            HiddenKey.SetActive(true);
            Cloak.SetActive(true);
            Ghost.speed = 3.0f;
            Ghost.waitTime = 0.5f;
            StaticData.BatteryLife = 10;
            MainUI.SetActive(true);
            HUD.SetActive(true);
            GameCheckCanvas.SetActive(false);

            Wall.SetActive(false);
            Trigger.SetActive(false);
            interact.SubIntButton.SetActive(true);
            interact.SubIntButton_Cloak.SetActive(true);
        }
    }

    public void YesNo()
    {
        doubleCheck.SetActive(false);
        GameCheckCanvas.SetActive(true);
        YesCheck = false;
    }

    public void NoYes()
    {
        if(NoCheck == true)
            SceneManager.LoadScene(3); // Ending First
    }

    public void NoNo()
    {
        doubleCheck.SetActive(false);
        GameCheckCanvas.SetActive(true);
        NoCheck = false;
    }
}
