using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Note_Buttons : MonoBehaviour
{
    private const string Note = "Note";
    private string Change;
    [SerializeField] private GameObject Canvas;
    [SerializeField] private TextMeshProUGUI NotePage;
    [SerializeField] private GameObject Button;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 1; i <= 14; i++)
        {
            Change = Note + i;
            if (this.gameObject.name == Change)
            {
                if (StaticData.Note1 != true)
                    Button.SetActive(false);
                else
                    Button.SetActive(true);

                if (StaticData.Note2 != true)
                    Button.SetActive(false);
                else
                    Button.SetActive(true);

                if (StaticData.Note3 != true)
                    Button.SetActive(false);
                else
                    Button.SetActive(true);

                if (StaticData.Note4 != true)
                    Button.SetActive(false);
                else
                    Button.SetActive(true);

                if (StaticData.Note5 != true)
                    Button.SetActive(false);
                else
                    Button.SetActive(true);

                if (StaticData.Note6 != true)
                    Button.SetActive(false);
                else
                    Button.SetActive(true);

                if (StaticData.Note7 != true)
                    Button.SetActive(false);
                else
                    Button.SetActive(true);

                if (StaticData.Note8 != true)
                    Button.SetActive(false);
                else
                    Button.SetActive(true);

                if (StaticData.Note9 != true)
                    Button.SetActive(false);
                else
                    Button.SetActive(true);

                if (StaticData.Note10 != true)
                    Button.SetActive(false);
                else
                    Button.SetActive(true);

                if (StaticData.Note11 != true)
                    Button.SetActive(false);
                else
                    Button.SetActive(true);

                if (StaticData.Note12 != true)
                    Button.SetActive(false);
                else
                    Button.SetActive(true);

                if (StaticData.Note13 != true)
                    Button.SetActive(false);
                else
                    Button.SetActive(true);

                if (StaticData.Note14 != true)
                    Button.SetActive(false);
                else
                    Button.SetActive(true);


            }
            Change = Note;
        }
    }

    public void Note_OnButtonClick()
    {
        for (int i = 1; i < 14; i++)
        {
            Change = Note + i;
            if (this.gameObject.name == Change )
            {
                {
                    if (StaticData.Note1 == true)
                    {
                        Canvas.SetActive(true);
                        NotePage.text = " Note 1 Waiting To Be filled";
                    }
                    if (StaticData.Note2 == true)
                    {
                        Canvas.SetActive(true);
                        NotePage.text = " Note 2 Waiting To Be filled";
                    }
                    if (StaticData.Note3 == true)
                    {
                        Canvas.SetActive(true);
                        NotePage.text = " Note 3 Waiting To Be filled";
                    }
                    if (StaticData.Note4 == true)
                    {
                        Canvas.SetActive(true);
                        NotePage.text = " Note 4 Waiting To Be filled";
                    }
                    if (StaticData.Note5 == true)
                    {
                        Canvas.SetActive(true);
                        NotePage.text = " Note 5 Waiting To Be filled";
                    }
                    if (StaticData.Note6 == true)
                    {
                        Canvas.SetActive(true);
                        NotePage.text = " Note 6 Waiting To Be filled";
                    }
                    if (StaticData.Note7 == true)
                    {
                        Canvas.SetActive(true);
                        NotePage.text = " Note 7 Waiting To Be filled";
                    }
                    if (StaticData.Note8 == true)
                    {
                        Canvas.SetActive(true);
                        NotePage.text = " Note 8 Waiting To Be filled";
                    }
                    if (StaticData.Note9 == true)
                    {
                        Canvas.SetActive(true);
                        NotePage.text = " Note 9 Waiting To Be filled";
                    }
                    if (StaticData.Note10 == true)
                    {
                        Canvas.SetActive(true);
                        NotePage.text = " Note 10 Waiting To Be filled";
                    }
                    if (StaticData.Note11 == true)
                    {
                        Canvas.SetActive(true);
                        NotePage.text = " Note 11 Waiting To Be filled";
                    }
                    if (StaticData.Note12 == true)
                    {
                        Canvas.SetActive(true);
                        NotePage.text = " Note 12 Waiting To Be filled";
                    }
                    if (StaticData.Note13 == true)
                    {
                        Canvas.SetActive(true);
                        NotePage.text = " Note 13 Waiting To Be filled";
                    }
                    if (StaticData.Note14 == true)
                    {
                        Canvas.SetActive(true);
                        NotePage.text = " Note 14 Waiting To Be filled";
                    }
                }

            }
            Change = Note;
        }
    }
}
