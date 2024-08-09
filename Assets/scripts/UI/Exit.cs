using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Exit : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject HidingCanvas;
    [SerializeField] private GameObject MainUI;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonClick()
    {
        //exit
        if(StaticData.isHiding ==true)
        {
            Player.SetActive(true);
            HidingCanvas.SetActive(false);
            MainUI.SetActive(true);
        }
    }
}
