using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseInformation : MonoBehaviour
{
    [SerializeField] private GameObject Phone_UI;
    [SerializeField] private GameObject Information_UI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Close_Information()
    {
        Phone_UI.SetActive(true);
        Information_UI.SetActive(false);
    }
}
