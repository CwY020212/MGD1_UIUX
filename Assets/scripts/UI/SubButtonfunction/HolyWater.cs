using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolyWater : MonoBehaviour
{
    public bool Stunned = false;
    private float timer =10.0f;
    // Update is called once per frame
    void Update()
    {
        if (Stunned == true)
        {
            timer -= Time.deltaTime;
            if (timer <= 0.0f)
            {
                Stunned = false;
                StaticData.HolyWater = false;
                timer = 10.0f;
                this.enabled = false;
                StaticData.LineToBeShown = "Stun finished";
                this.gameObject.SetActive(false);
            }
        }
    }

    public void HolyWaterStun()
    {
        if(StaticData.HolyWater)
        {
            Stunned = true;
            StaticData.LineToBeShown = "Ghost is now stunned";
        }
        else
        {
            StaticData.LineToBeShown = "Haven't collected Holy Water";
        }

        if(this.enabled == false)
        {
            StaticData.LineToBeShown = "Item is used";
        }
    }
}
