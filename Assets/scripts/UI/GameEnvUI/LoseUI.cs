using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseUI : MonoBehaviour
{
    public TMP_Text Advices;
    public string[] lines;
    private string linetobeshown;
    private int rdnumber;

    private void Start()
    {
        rdnumber = (int)Random.Range(1, 5);
        switch(rdnumber)
        {
            case 1:
                linetobeshown = lines[0];
                break;
            case 2:
                linetobeshown = lines[1];
                break;
            case 3:
                linetobeshown = lines[2];
                break;
            case 4:
                linetobeshown = lines[3];
                break;
            case 5:
                linetobeshown = lines[4];
                break;

            default:
                linetobeshown = "You accidentally died";
                break;
        }
        Advices.text = linetobeshown;
    }

    public void restart()
    {
        SceneManager.LoadScene(1);
    }    
}
