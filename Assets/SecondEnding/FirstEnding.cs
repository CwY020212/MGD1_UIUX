using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstEnding : MonoBehaviour
{
    public GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.name =="Test(Clone)")
        {
            image.SetActive(true);

        }
    }
}
