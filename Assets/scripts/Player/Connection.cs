using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Television")
        {
            StaticData.TelevisionConnectionInRange = true;
        }

        if (collision.gameObject.name == "Radio")
        {
            StaticData.RadioConnectionInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Television")
        { 
        
            StaticData.TelevisionConnectionInRange = false;
        }

        if (collision.gameObject.name == "Radio")
        {
            StaticData.RadioConnectionInRange = false;
        }
    }
}
