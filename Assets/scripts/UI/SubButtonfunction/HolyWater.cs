using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolyWater : MonoBehaviour
{
    public bool Stunned = false;
    private float timer =10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
            }
        }
    }

    public void HolyWaterStun()
    {
        if(StaticData.HolyWater)
        {
            Stunned = true;
        }
    }
}
