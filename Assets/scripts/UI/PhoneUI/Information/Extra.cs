using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Extra : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Webpage;
    [SerializeField] private GameObject Panel1;
    [SerializeField] private GameObject Panel2;
    [SerializeField] private GameObject Panel3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExtraPage()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(true);
        Webpage.text = " Page 3 Waiting to be filled.";

    }
}
