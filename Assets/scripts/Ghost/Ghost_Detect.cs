using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_Detect : MonoBehaviour
{

    [SerializeField] private GameObject Lose_UI;
    [SerializeField] private GameObject MainInGame_UI;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Lose_UI.SetActive(true);
            MainInGame_UI.SetActive(false);
        }
    }
}
