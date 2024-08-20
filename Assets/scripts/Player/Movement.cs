using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Terresquall;
using UnityEngine.Rendering;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public float movespeed = 400.0f;
    private float hor;
    private float Ver;
    public bool isPaused = false;
    private int layerindex;

    [SerializeField] private GameObject Middle_BackSide;
    [SerializeField] private GameObject Middle_FrontSide;
    [SerializeField] private GameObject Middle_Cover;

    [SerializeField] private GameObject Bottom_BackSide;
    [SerializeField] private GameObject Bottom_FrontSide;
    [SerializeField] private GameObject Bottom_Cover;

    [SerializeField] private GameObject Top_BackSide;
    [SerializeField] private GameObject Top_FrontSide;
    [SerializeField] private GameObject Top_Cover;

    [SerializeField] private GameObject Hidden_BackSide;
    [SerializeField] private GameObject Hidden_FrontSide;
    [SerializeField] private GameObject Hidden_Cover;

    [SerializeField] private GameObject Cupboard;


    private void Start()
    {
        layerindex = this.gameObject.GetComponent<SortingGroup>().sortingOrder;
        rb = GetComponent<Rigidbody2D>();
        Middle_FrontSide.SetActive(true);
        Bottom_FrontSide.SetActive(true);
        Top_FrontSide.SetActive(true);
        Hidden_FrontSide.SetActive(true);
        Top_Cover.SetActive(true);
        Bottom_Cover.SetActive(true);
        Middle_Cover.SetActive(true);
        Hidden_Cover.SetActive(true);
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //to adjust the view by entering different trigger
        if (collision.gameObject.CompareTag("Middle"))
        {
            Middle_FrontSide.SetActive(true);
            Middle_BackSide.SetActive(true);
            Bottom_BackSide.SetActive(false);
            Top_FrontSide.SetActive(false);
            this.gameObject.GetComponent<SortingGroup>().sortingOrder = 0;
            Middle_Cover.SetActive(false);
            Bottom_Cover.SetActive(true);
            Top_Cover.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Bottom"))
        {
            Bottom_BackSide.SetActive(true);
            this.gameObject.GetComponent<SortingGroup>().sortingOrder = 3;
            Middle_Cover.SetActive(true);
            Bottom_Cover.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Top"))
        {
            Top_BackSide.SetActive(true);
            Top_FrontSide.SetActive(true);
            Middle_BackSide.SetActive(false);
            this.gameObject.GetComponent<SortingGroup>().sortingOrder = -3;
            Top_Cover.SetActive(false);
            Middle_Cover.SetActive(true);
            Hidden_Cover.SetActive(true);
            Cupboard.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Hidden"))
        {
            Top_BackSide.SetActive(false);
            Hidden_BackSide.SetActive(true);
            this.gameObject.GetComponent<SortingGroup>().sortingOrder = -5;
            Hidden_Cover.SetActive(false);
            Top_Cover.SetActive(true);
            Cupboard.SetActive(false);
        }
    }
}
