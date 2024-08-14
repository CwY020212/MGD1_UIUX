using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HowToMove : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Webpage;
    [SerializeField] private GameObject Enabled;
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
        Enabled.SetActive(true);
        Webpage.text = "Waiting to be filled.";

    }
}
