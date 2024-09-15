using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    [Header("Iamges && places")]
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Image3;
    public GameObject Image4;

    [Header("Text Changing")]
    public TMP_Text Tutor;
    public string[] LinesToBeShown;
    private int Lines_Index = 0;

    [Header("Pages to be closed")]
    public GameObject HUD;
    public GameObject MainUI;
    public GameObject TutorialPage;

    private int Maximum;
    private void Start()
    {
        Maximum = LinesToBeShown.Length;
        Tutor.text = LinesToBeShown[0];
    }
    public void tutor_ShowLine_Forwrads()
    {
        Lines_Index++;
        if(Lines_Index < Maximum)
            Tutor.text = LinesToBeShown[Lines_Index];

        if (Lines_Index == 0)
        {
            Image1.SetActive(false);
            Image2.SetActive(false);
            Image3.SetActive(false);
            Image4.SetActive(false);
        }
        if (Lines_Index == 2)
        {
            Image1.SetActive(true);
            Image3.SetActive(true);
        }
        if(Lines_Index == 3)
        {
            Image1.SetActive(false);
            Image3.SetActive(false);
            Image2.SetActive(true);
        }
        if(Lines_Index == 4)
        {
            Image2.SetActive(false);
            Image4.SetActive(true);
        }
        if (Lines_Index == 5)
        {
            Image4.SetActive(false);
        }
        if(Lines_Index >= Maximum)
        {
            HUD.SetActive(true);
            MainUI.SetActive(true);
            TutorialPage.SetActive(false);
        }
    }

    public void tutor_Showline_BackWard()
    {
        if (Lines_Index >= 1)
        {
            Lines_Index--;
            Tutor.text = LinesToBeShown[Lines_Index];
            if(Lines_Index == 0)
            {
                Image1.SetActive(false);
                Image2.SetActive(false);
                Image3.SetActive(false);
                Image4.SetActive(false);
            }

            if (Lines_Index == 2)
            {
                Image1.SetActive(true);
                Image2.SetActive(false);
                Image3.SetActive(true);
                Image4.SetActive(false);
            }
            if (Lines_Index == 3)
            {
                Image1.SetActive(false);
                Image3.SetActive(false);
                Image2.SetActive(true);
                Image4.SetActive(false);
            }
            if (Lines_Index == 4)
            {
                Image1.SetActive(false);
                Image2.SetActive(false);
                Image3.SetActive(false);
                Image4.SetActive(true);
            }
            if (Lines_Index == 5)
            {
                Image1.SetActive(false);
                Image2.SetActive(false);
                Image3.SetActive(false);
                Image4.SetActive(false);
            }
        }
    }
}
