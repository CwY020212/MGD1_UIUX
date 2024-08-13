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

    public void OnTriggerStay2D(Collider2D collision)
    {
        ItemsInRange = new bool[9];
        AbilityInRange = new bool[4];
        NotesInRange = new bool[14];
        int count = 0;

        if (collision.gameObject.CompareTag("Items"))
        {
            if (collision.gameObject.name == "HolyWater")
            {
                ItemsInRange[0] = true;
                Debug.Log("HolyWater In Range");
            }
            if (collision.gameObject.name == "Crucifix")
            {
                ItemsInRange[1] = true;
                Debug.Log("Crucifix In Range");
            }
            if (collision.gameObject.name == "Salt")
            {
                ItemsInRange[2] = true;
                Debug.Log("Salt In Range");
            }
            if (collision.gameObject.name == "Pepper")
            {
                ItemsInRange[3] = true;
                Debug.Log("Pepper In Range");
            }
            if (collision.gameObject.name == "Hammer")
            {
                ItemsInRange[4] = true;
                Debug.Log("Hammer In Range");
            }
            if (collision.gameObject.name == "Key1")
            {
                ItemsInRange[5] = true;
                Debug.Log("Key1 In Range");
            }
            if (collision.gameObject.name == "Key2")
            {
                ItemsInRange[6] = true;
                Debug.Log("Key2 In Range");
            }
            if (collision.gameObject.name == "Key3")
            {
                ItemsInRange[7] = true;
                Debug.Log("Key3 In Range");
            }
            if (collision.gameObject.name == "Key4")
            {
                ItemsInRange[8] = true;
                Debug.Log("Key4 In Range");
            }

        }

        if (collision.gameObject.CompareTag("Ability"))
        {
            if (collision.gameObject.name == "Television")
            {
                AbilityInRange[0] = true;
                Debug.Log("Television In Range");
            }
            if (collision.gameObject.name == "Radio")
            {
                AbilityInRange[1] = true;
                Debug.Log("Radio In Range");
            }
            if (collision.gameObject.name == "Cloak")
            {
                AbilityInRange[2] = true;
                Debug.Log("Cloak In Range");
            }
            if (collision.gameObject.name == "Mimicking")
            {
                AbilityInRange[3] = true;
                Debug.Log("Mimicking In Range");
            }
        }

        for (int j = 1; j < 15; j++)
        {
            Changes = Notes + j;
            if (collision.gameObject.name == Changes)
            {
                NotesInRange[count] = true; 
                Debug.Log(Changes+ " In Range");
                count++;
            }
            Changes = Notes;
        }

        if (collision.gameObject.CompareTag("HidingSpot"))
        {
            StaticData.isHiding = true;
            Debug.Log("Hiding in Range");
        }

        if(collision.gameObject.CompareTag("StatueSpot"))
        {
            StaticData.isStatue = true;
            Debug.Log("Statue in Range");
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        int count = 0;
        if(collision.gameObject.CompareTag("Items"))
        {
            for (int i = 0; i < 9; i++)
            {
                ItemsInRange[i] = false;
            }
            Debug.Log("Items Out Of Range");
        }
        if (collision.gameObject.CompareTag("Ability"))
        {
            for (int i = 0; i < 4; i++)
            {
                AbilityInRange[i] = false;
            }
            Debug.Log("Ability Out Of Range");
        }

        for (int j = 1; j < 15; j++)
        {
            Changes = Notes + j;
            if (collision.gameObject.name == Changes)
            {
                NotesInRange[count] = false;
                Debug.Log(Changes + " Out of Range");
                count++;
            }
            Changes = Notes;
        }
    }

}
