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
        Webpage.text = "FizzyCola Racing Cup Sponsors:" +
            "<br>" +
            "<br>Claris" +
            "<br>Fizzy SDN BHD" +
            "<br>Coke SDN BHD" +
            "<br>Best Racing Enterprise" +
            "<br>" +
            "<br>Past Years Winners:" +
            "<br>(200X)<Savir>(200X)" +
            "<br>The First Woman Winner In FRC history" +
            "<br>" +
            "<br>(201X)<Marson>(201X)" +
            "<br>The Fatest Racer in FRC history" +
            "<br>" +
            "<br>(201X)<Prans>(201X)" +
            "<br>" +
            "<br>(201X)<LEE WEI XUAN>(201X)" +
            "<br>" +
            "<br>(201X)<WAI YAU>(201X)" +
            "<br>" +
            "<br>(201X)<TVON>(201X)"+
            "<br>" +
            "<br>(201X)<CHEE KIN>(201X)" +
            "<br>" +
            "<br>(201X)<LZY>(201X)" +
            "<br>" +
            "<br>(201X)<OZY>(201X)" +
            "<br>(Gone Missing)";
    }
}
