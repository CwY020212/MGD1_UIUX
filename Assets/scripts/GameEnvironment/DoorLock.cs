using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    [SerializeField] private GameObject FakeWall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void BreakFakeWall()
    {
        if (StaticData.Hammer)
        {
            Destroy(FakeWall);
        }
    }

}
