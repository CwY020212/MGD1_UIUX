using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BagReturn : MonoBehaviour
{
    public Movement movement;
    [SerializeField] private GameObject Inventory_UI;
    [SerializeField] private GameObject MainInGame_UI;
    public Animator Manager;

    public void OnButtonClick()
    {
        Manager.SetBool("Inventory_Closed", true);
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.5f);
        if (movement.isPaused == true)
            movement.isPaused = false;
        else
            movement.isPaused = true;

        if (movement.isPaused == false)
        {
            Inventory_UI.SetActive(false);
            if (movement.isActiveAndEnabled == true)
                MainInGame_UI.SetActive(true);
        }
    }
}
