using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bag : MonoBehaviour
{
    public Movement movement;
    [SerializeField] private GameObject Inventory_UI;
    [SerializeField] private GameObject MainInGame_UI;
    [SerializeField] private GameObject Crucifix;
    [SerializeField] private GameObject HolyWater;
    [SerializeField] private GameObject Salt;
    [SerializeField] private GameObject Pepper;
    [SerializeField] private GameObject Hammer;
    [SerializeField] private GameObject Key1;
    [SerializeField] private GameObject Key2;
    [SerializeField] private GameObject Key3;
    [SerializeField] private GameObject Key4;

    public Animator Manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticData.HolyWater == true)
        {
            HolyWater.SetActive(true);
        }
        if (StaticData.Crucifix == true)
        {
            Crucifix.SetActive(true);
        }
        if (StaticData.Salt == true)
        {
            Salt.SetActive(true);
        }
        if (StaticData.Pepper == true)
        {
            Pepper.SetActive(true);
        }
        if (StaticData.Hammer == true)
        {
            Hammer.SetActive(true);
        }
        if (StaticData.Key1 == true)
        {
            Key1.SetActive(true);
        }
        if (StaticData.Key2 == true)
        {
            Key2.SetActive(true);
        }
        if (StaticData.Key3 == true)
        {
            Key3.SetActive(true);
        }
        if (StaticData.Key4 == true)
        {
            Key4.SetActive(true);
        }
    }

    public void OnButtonClick()
    {
        Manager.SetBool("Inventory_Closed", false);
        if (movement.isPaused == false)
            movement.isPaused = true;
        else
            movement.isPaused = false;

        if (movement.isPaused == true)
        {
            Inventory_UI.SetActive(true);
            MainInGame_UI.SetActive(false);
        }

    }
}
