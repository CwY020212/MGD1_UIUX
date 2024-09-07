using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCheckNormal : MonoBehaviour
{
    private bool check = false;

    // Update is called once per frame
    void Update()
    {
        if (!check)
        {
            if (this.gameObject.name == "Normal(Clone)")
            {
                StaticData.diff = 1;
                check = true;
                Debug.Log("Normal though");
            }
        }
    }
}
