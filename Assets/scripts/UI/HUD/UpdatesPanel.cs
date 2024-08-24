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

    private bool Curr1 = false;
    private bool Curr2 = false;
    private bool Curr3 = false;

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
        if (StaticData.LineToBeShown != null)
        {
            //to change the content of line1
            if (!Updates1.activeInHierarchy)
            {
                Updates1.SetActive(true);
                if(!Curr3)
                    Line1.text = StaticData.LineToBeShown;
                StartCoroutine(Wait());
            }



            //to check if line1 is in progress, and if there is new updates in staticdata
            if (!Updates2.activeInHierarchy)
                if (Curr1 == true && Line1.text != StaticData.LineToBeShown)
                {
                    Updates2.SetActive(true);
                    Line2.text = StaticData.LineToBeShown;
                    StartCoroutine(WaitInLine());
                }



            //to check if line2 is in progress, and if there is new updates in staticdata
            Line3.text = StaticData.LineToBeShown;

            if (Line1.text != StaticData.LineToBeShown && Line2.text != StaticData.LineToBeShown)
            {
                Updates3.SetActive(true);
                StartCoroutine(WaitInLast());
            }

        }
    }

    IEnumerator Wait()
    {
        Curr1 = true;
        yield return new WaitForSeconds(7.0f);
        EndLine(Updates1, Line1, Curr1);
    }

    IEnumerator WaitInLine()
    {
        Curr2 = true;
        yield return new WaitForSeconds(7.0f);
        if (Curr1 == false)
            yield return new WaitForSeconds(3.0f);
        EndLine(Updates2, Line2, Curr2);
    }

    IEnumerator WaitInLast()
    {
        Curr3 = true;
        yield return new WaitForSeconds(7.0f);
        if (Curr2 == false)
            yield return new WaitForSeconds(5.0f);
        EndLine(Updates3, Line3,Curr3);
    }

    void EndLine(GameObject GB, TextMeshProUGUI Line, bool Curr)
    {
        StaticData.LineToBeShown = null;
        GB.SetActive(false);
        Line.text = null;
        Curr = false;
    }
}
