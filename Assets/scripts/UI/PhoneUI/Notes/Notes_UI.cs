using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes_UI : MonoBehaviour
{
    [SerializeField] private GameObject Phone_UI;
    [SerializeField] private GameObject NotesUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Notes_UI_Open()
    {
        Phone_UI.SetActive(false);
        NotesUI.SetActive(true);
    }
}
