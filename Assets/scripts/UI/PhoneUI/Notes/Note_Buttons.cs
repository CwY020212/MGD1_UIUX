using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Note_Buttons : MonoBehaviour
{
    private const string Note = "Note";
    private string Change;
    [SerializeField] private GameObject Canvas;
    [SerializeField] private TextMeshProUGUI NotePage;
    [SerializeField] private GameObject NotePageGO;
    [SerializeField] private GameObject CloseNotePage_Button;
    [SerializeField] private GameObject CloseTab;


    public void Note_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note1 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = " Note 1 Waiting To Be filled";
        }
    }

    public void Note2_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note2 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = " Note 2 Waiting To Be filled";
        }
    }

    public void Note3_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note3 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = " Note 3 Waiting To Be filled";
        }
    }

    public void Note4_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note4 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = " Note 4 Waiting To Be filled";
        }
    }
    public void Note5_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note3 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = " Note 5 Waiting To Be filled";
        }
    }
    public void Note6_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note6 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = " Note 6 Waiting To Be filled";
        }
    }
    public void Note7_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note7 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = " Note 7 Waiting To Be filled";
        }
    }
    public void Note8_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note8 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = " Note 8 Waiting To Be filled";
        }
    }
    public void Note9_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note9 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = " Note 9 Waiting To Be filled";
        }
    }
    public void Note10_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note10 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = " Note 10 Waiting To Be filled";
        }
    }
    public void Note11_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note11 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = " Note 11 Waiting To Be filled";
        }
    }
    public void Note12_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note12 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = " Note 12 Waiting To Be filled";
        }
    }
    public void Note13_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note13 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = " Note 13 Waiting To Be filled";
        }
    }
    public void Note14_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note14 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = " Note 14 Waiting To Be filled";
        }
    }
}

