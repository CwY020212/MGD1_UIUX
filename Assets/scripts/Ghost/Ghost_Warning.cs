using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_Warning : MonoBehaviour
{

    [SerializeField] private GameObject Warning;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Warning.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Warning.SetActive(false);
        }
    }
}
