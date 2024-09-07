using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCheckHard : MonoBehaviour
{
    private bool check = false;


    void Update()
    {
        if (!check)
        {
            if (this.gameObject.name == "Hard(Clone)")
            {
                StaticData.diff = 2; // setting difficulty
                check = true;
                Debug.Log("Damn Hard LOL");
            }
        }
    }
}
