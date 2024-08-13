using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PhoneUI : MonoBehaviour
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
        if (movement.isPaused == false)
            movement.isPaused = true;
        else
            movement.isPaused = false;

        if (movement.isPaused == true)
        {
            Phone_UI.SetActive(true);
            MainInGame_UI.SetActive(false);
        }
    }
}
