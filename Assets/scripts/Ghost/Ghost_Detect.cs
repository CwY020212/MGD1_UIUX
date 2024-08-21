using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_Detect : MonoBehaviour
{

    [SerializeField] private GameObject Lose_UI;
    [SerializeField] private GameObject MainInGame_UI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Lose_UI.SetActive(true);
            MainInGame_UI.SetActive(false);
        }
    }
}
