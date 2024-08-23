using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour
{
    public bool[] ItemsInRange;
    public bool[] AbilityInRange;
    public bool[] NotesInRange;
    private const string Notes = "Note";
    private string Changes;
    [SerializeField] private GameObject glowing_effect;

    public void OnTriggerStay2D(Collider2D collision)
    {
        ItemsInRange = new bool[9];
        AbilityInRange = new bool[4];
        NotesInRange = new bool[14];
        int count = 0;

        if (collision.gameObject.CompareTag("Items"))
        {
            glowing_effect.SetActive(true);
            if (collision.gameObject.name == "HolyWater")
            {
                ItemsInRange[0] = true;
            }
            if (collision.gameObject.name == "Crucifix")
            {
                ItemsInRange[1] = true;
            }
            if (collision.gameObject.name == "Salt")
            {
                ItemsInRange[2] = true;
            }
            if (collision.gameObject.name == "Pepper")
            {
                ItemsInRange[3] = true;
            }
            if (collision.gameObject.name == "Hammer")
            {
                ItemsInRange[4] = true;
            }
            if (collision.gameObject.name == "Key1")
            {
                ItemsInRange[5] = true;
            }
            if (collision.gameObject.name == "Key2")
            {
                ItemsInRange[6] = true;
            }
            if (collision.gameObject.name == "Key3")
            {
                ItemsInRange[7] = true;
            }
            if (collision.gameObject.name == "Key4")
            {
                ItemsInRange[8] = true;
            }

        }

        if (collision.gameObject.CompareTag("Ability"))
        {
            glowing_effect.SetActive(true);
            if (collision.gameObject.name == "Television")
            {
                AbilityInRange[0] = true;
            }
            if (collision.gameObject.name == "Radio")
            {
                AbilityInRange[1] = true;
            }
            if (collision.gameObject.name == "Cloak")
            {
                AbilityInRange[2] = true;
            }
            if (collision.gameObject.name == "Mimicking")
            {
                AbilityInRange[3] = true;
            }
        }

        for (int j = 1; j < 15; j++)
        {

            Changes = Notes + j;
            if (collision.gameObject.name == Changes)
            {
                glowing_effect.SetActive(true);
                NotesInRange[count] = true;
                
            }
            Changes = Notes;
            count++;
        }

        if (collision.gameObject.CompareTag("HidingSpot"))
        {
            glowing_effect.SetActive(true);
            StaticData.isHiding = true;
        }

        if(collision.gameObject.CompareTag("StatueSpot"))
        {
            glowing_effect.SetActive(true);
            StaticData.isStatue = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        int count = 0;
        if(collision.gameObject.CompareTag("Items"))
        {
            glowing_effect.SetActive(false);
            for (int i = 0; i < 9; i++)
            {
                ItemsInRange[i] = false;
            }
        }
        if (collision.gameObject.CompareTag("Ability"))
        {
            glowing_effect.SetActive(false);
            for (int i = 0; i < 4; i++)
            {
                AbilityInRange[i] = false;
            }
        }

        for (int j = 1; j < 15; j++)
        {
            Changes = Notes + j;
            if (collision.gameObject.name == Changes)
            {
                glowing_effect.SetActive(false);
                NotesInRange[count] = false;
                count++;
            }
            Changes = Notes;
        }
        if (collision.gameObject.CompareTag("HidingSpot"))
        {
            glowing_effect.SetActive(false);
        }
        if (collision.gameObject.CompareTag("StatueSpot"))
        {
            glowing_effect.SetActive(false);
        }
    }

}
