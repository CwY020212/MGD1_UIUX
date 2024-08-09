using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Terresquall;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private float movespeed = 500.0f;
    private float hor;
    private float Ver;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hor = VirtualJoystick.GetAxis("Horizontal", 0);
        Ver = VirtualJoystick.GetAxis("Vertical", 0);
        rb.velocity = new Vector2(hor * movespeed * Time.deltaTime, Ver * movespeed * Time.deltaTime);
    }
}
