using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Close : MonoBehaviour
{
    public GameObject Phone_UI;
    public GameObject MainInGame_UI;
    public Movement movement;

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
        if (movement.isPaused == true)
            movement.isPaused = false;
        else
            movement.isPaused = true;

        if (movement.isPaused == false)
        {
            Phone_UI.SetActive(false);
            MainInGame_UI.SetActive(true);
        }
    }
}
