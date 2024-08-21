using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdatesPanel : MonoBehaviour
{
    [SerializeField] private GameObject Updates1;
    [SerializeField] private GameObject Updates2;
    [SerializeField] private GameObject Updates3;
    [SerializeField] private TextMeshProUGUI Line1;
    [SerializeField] private TextMeshProUGUI Line2;
    [SerializeField] private TextMeshProUGUI Line3;

    private const float timeWanted = 7.0f;
    private bool Curr1 = false;
    private bool Curr2 = false;
    private bool Curr3 = false;
    private float time1 = timeWanted;
    private float time2 = timeWanted;
    private float time3 = timeWanted;

    // Start is called before the first frame update
    void Start()
    {
        Line1.text = "";
        Line2.text = "";
        Line3.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(time1);
        Debug.Log(StaticData.LineToBeShown);

        if (StaticData.LineToBeShown != null)
        {
            Updates1.SetActive(true);
        }
        if (Updates1.activeInHierarchy)
        {
            //to check if there is sentence in line1, if not then change the content of line1
            if(Curr1 == false)
                Line1.text = StaticData.LineToBeShown;

            //timer to show line1
            time1 -= Time.deltaTime;

            //line 1 is in progress
            Curr1 = true;

            if (time1 <= 0)
            {
                Updates1.SetActive(false);
                time1 = timeWanted;
                Curr1 = false;
                StaticData.LineToBeShown = null;
            }
        }


    }
}
