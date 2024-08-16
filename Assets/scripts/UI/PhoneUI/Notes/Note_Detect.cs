using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Note_Detect : MonoBehaviour
{
    [SerializeField] private GameObject Button1;
    [SerializeField] private GameObject Button2;
    [SerializeField] private GameObject Button3;
    [SerializeField] private GameObject Button4;
    [SerializeField] private GameObject Button5;
    [SerializeField] private GameObject Button6;
    [SerializeField] private GameObject Button7;
    [SerializeField] private GameObject Button8;
    [SerializeField] private GameObject Button9;
    [SerializeField] private GameObject Button10;
    [SerializeField] private GameObject Button11;
    [SerializeField] private GameObject Button12;
    [SerializeField] private GameObject Button13;
    [SerializeField] private GameObject Button14;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(StaticData.Note13);

        if (StaticData.Note1 == true)
            Button1.SetActive(true);

        if (StaticData.Note2 == true)
            Button2.SetActive(true);

        if (StaticData.Note3 == true)
            Button3.SetActive(true);

        if (StaticData.Note4 == true)
            Button4.SetActive(true);

        if (StaticData.Note5 == true)
            Button5.SetActive(true);

        if (StaticData.Note6 == true)
            Button6.SetActive(true);

        if (StaticData.Note7 == true)
            Button7.SetActive(true);
        
        if (StaticData.Note8 == true)
            Button8.SetActive(true);

        if (StaticData.Note9 == true)
            Button9.SetActive(true);

        if (StaticData.Note10 == true)
            Button10.SetActive(true);

        if (StaticData.Note11 == true)
            Button11.SetActive(true);

        if (StaticData.Note12 == true)
            Button12.SetActive(true);

        if (StaticData.Note13 == true)
            Button13.SetActive(true);

        if (StaticData.Note14 == true)
            Button14.SetActive(true);
    }
}
