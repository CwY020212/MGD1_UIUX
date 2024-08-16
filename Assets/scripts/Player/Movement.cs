using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Terresquall;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public float movespeed = 400.0f;
    private float hor;
    private float Ver;
    public bool isPaused = false;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isPaused == false)
        {
            hor = VirtualJoystick.GetAxis("Horizontal", 0);
            Ver = VirtualJoystick.GetAxis("Vertical", 0);
            rb.velocity = new Vector2(hor * movespeed * Time.deltaTime, Ver * movespeed * Time.deltaTime);
        }
    }
}
