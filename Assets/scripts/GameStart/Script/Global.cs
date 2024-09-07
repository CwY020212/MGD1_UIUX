using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Global : MonoBehaviour
{
    public Light2D Glo_light;
    // Start is called before the first frame update
    private void Start()
    {
        Glo_light.intensity += StaticData.brightness / 50;
    }
}
