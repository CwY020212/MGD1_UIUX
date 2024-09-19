using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checking : MonoBehaviour
{
    public GameObject CheckingPanel;
    public bool Diff_check = false;
    public Difficulty_Dropdown DiffScript;

    //org Diff
    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private GameObject Ghost_Detect;
    [SerializeField] private GameObject Ghost_Warning;
    public GhostMovement ghost;

    private const float DetectSizeX = 2.0f; //default
    private const float DetectSizeY = 1.5f; //default
    private float DetectX = DetectSizeX;
    private float DetectY = DetectSizeY;

    private const float WarningSizeX = 16.0f; //default
    private const float WarningSizeY = 9f; //default
    private float WarningX = WarningSizeX;
    private float WarningY = WarningSizeY;

    private void Start()
    {
        DiffScript.Choice = StaticData.diff;
        dropdown.value = DiffScript.Choice;

        if (DiffScript.Choice == 0)// Easy
        {
            StaticData.BatteryLife = 100;
            StaticData.Difficulty = true;
            Ghost_Detect.GetComponent<BoxCollider2D>().size = new Vector2(DetectSizeX, DetectSizeY);
            Ghost_Warning.GetComponent<BoxCollider2D>().size = new Vector2(WarningSizeX, WarningSizeY);
            ghost.speed = 1.0f;
        }
        else if (DiffScript.Choice == 1)// Normal
        {
            DetectX = DetectSizeX + 1.0f;
            DetectY = DetectSizeY + 1.0f;
            WarningX = WarningSizeX - 3.0f;
            WarningY = WarningSizeY - 1.0f;
            StaticData.BatteryLife = 60;
            StaticData.Difficulty = true;
            ghost.speed = 1.5f;
            Ghost_Detect.GetComponent<BoxCollider2D>().size = new Vector2(DetectX, DetectY);
            Ghost_Warning.GetComponent<BoxCollider2D>().size = new Vector2(WarningX, WarningY);
        }
        else if (DiffScript.Choice == 2) // Hard
        {
            DetectX = DetectSizeX + 1.5f;
            DetectY = DetectSizeY + 1.5f;
            WarningX = WarningSizeX - 6.0f;
            WarningY = WarningSizeY - 3.0f;
            StaticData.BatteryLife = 40;
            StaticData.Difficulty = true;
            ghost.speed = 2.0f;
            Ghost_Detect.GetComponent<BoxCollider2D>().size = new Vector2(DetectX, DetectY);
            Ghost_Warning.GetComponent<BoxCollider2D>().size = new Vector2(WarningX, WarningY);
        }
    }

    private void Update()
    {
        if (Diff_check == true)
        {
            if (DiffScript.Choice == 0)// Easy
            {
                StaticData.diff = 0;
            }
            else if (DiffScript.Choice == 1)// Normal
            {
                StaticData.diff = 1;
            }
            else if (DiffScript.Choice == 2) // Hard
            {
                StaticData.diff = 2;
            }
            SceneManager.LoadScene(2);
        }
    }

    public void DiffcultyEnsure()
    {
        Diff_check = true;
        CheckingPanel.SetActive(false);
    }

    public void DifficultyDeny()
    {
        Diff_check = false;
        CheckingPanel.SetActive(false);
    }

}
