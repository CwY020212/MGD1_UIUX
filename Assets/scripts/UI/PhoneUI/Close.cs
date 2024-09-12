using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Close : MonoBehaviour
{
    public GameObject Phone_UI;
    public GameObject MainInGame_UI;
    public Movement movement;
    public Animator Manager;

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
        Manager.SetBool("Phone_Closed", true);
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.8f);
        if (movement.isPaused == true)
            movement.isPaused = false;
        else
            movement.isPaused = true;

        if (movement.isPaused == false)
        {
            Phone_UI.SetActive(false);
            if (movement.isActiveAndEnabled == true)
                MainInGame_UI.SetActive(true);
        }
    }
}
