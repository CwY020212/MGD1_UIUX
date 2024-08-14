using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseTab_Connect : MonoBehaviour
{
    [SerializeField] private GameObject Connect_UI;
    [SerializeField] private GameObject Phone_UI;
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
        Connect_UI.SetActive(false);
        Phone_UI.SetActive(true);
    }
}
