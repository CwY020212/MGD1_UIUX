using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HowToMove : MonoBehaviour
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

    public void HowToMovePage()
    {
        Panel1.SetActive(true);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Webpage.text = " Page 1 Waiting to be filled.";

    }
}
