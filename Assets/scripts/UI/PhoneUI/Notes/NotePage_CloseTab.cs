using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePage_CloseTab : MonoBehaviour
{
    [SerializeField] private GameObject CloseTab;
    [SerializeField] private GameObject Canvas;
    [SerializeField] private GameObject NotePage;
    [SerializeField] private GameObject CloseNotePage_Button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseNotePageButton()
    {
        CloseTab.SetActive(true);
        NotePage.SetActive(false);
        Canvas.SetActive(false);
        CloseNotePage_Button.SetActive(false);
    }
}
