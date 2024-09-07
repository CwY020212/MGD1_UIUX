using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCheck : MonoBehaviour
{
    private bool check = false;

    // Update is called once per frame
    void Update()
    {
        if (!check)
        {
            if (this.gameObject.name == "Easy(Clone)")
            {
                StaticData.diff = 0;
                check = true;
                Debug.Log("It was EZ");
            }
        }
    }
}
