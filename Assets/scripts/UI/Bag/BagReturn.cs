using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BagReturn : MonoBehaviour
{
    public Movement movement;
    [SerializeField] private GameObject Inventory_UI;
    [SerializeField] private GameObject MainInGame_UI;
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
            Inventory_UI.SetActive(false);
            MainInGame_UI.SetActive(true);
        }
    }
}
