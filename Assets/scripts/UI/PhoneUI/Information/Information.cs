using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Information : MonoBehaviour
{
    [SerializeField] private GameObject Information_UI;
    [SerializeField] private TextMeshProUGUI Webpage;
    // Start is called before the first frame update
    void Start()
    {
        Webpage.text = "Fizzy Cola";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenInformation()
    {
        Information_UI.SetActive(true);
    }
}
