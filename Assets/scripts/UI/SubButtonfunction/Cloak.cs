using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloak : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private bool Pressed = false;
    private float timer = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Pressed == true)
        {
            timer -= Time.deltaTime;
            if(timer <=0.0f)
            {
                Player.tag = "Player";
                timer = 15.0f;
                Pressed = false;
                StaticData.Cloak = false;
                this.enabled = false;
                StaticData.LineToBeShown = "Invisible finish";
                this.gameObject.SetActive(false);
            }
        }
    }

    public void Invisible()
    {
        if (StaticData.Cloak == true)
        {
            Player.tag = "HidingSpot";
            Pressed = true;
            StaticData.LineToBeShown = "You are now invisible";
        }
        else
        {
            StaticData.LineToBeShown = "Haven't Collected Cloak";
        }

        if (this.enabled == false)
        {
            StaticData.LineToBeShown = "Item is used";
        }
    }
}
