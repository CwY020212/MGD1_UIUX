using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Terresquall;
using UnityEngine.Rendering;
using Cinemachine;
using Unity.VisualScripting;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public float movespeed = 100.0f;
    private float hor;
    private float Ver;
    public bool isPaused = false;
    private int layerindex;

    [SerializeField] private GameObject Capsule;

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
    [SerializeField] private GameObject Cupboard_Living;
    [SerializeField] private GameObject Television;

    [SerializeField] private Animator Animate;

    [SerializeField] private GameObject WarningCheck;
    [SerializeField] private CinemachineVirtualCamera VirtualCamera; 
    public GameSceneMusic MusicManager;
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
        if(WarningCheck.activeInHierarchy)
        {
            Animate.SetBool("IsWarning", true);
            if(VirtualCamera.m_Lens.OrthographicSize >=2.0f)
            VirtualCamera.m_Lens.OrthographicSize -= 0.01f;
        }
        else
        {
            Animate.SetBool("IsWarning", false);
            if(VirtualCamera.m_Lens.OrthographicSize <=3.5f)
            VirtualCamera.m_Lens.OrthographicSize +=0.01f;
        }
        
        if (isPaused == false)
        {
            hor = VirtualJoystick.GetAxis("Horizontal", 0);
            Ver = VirtualJoystick.GetAxis("Vertical", 0);
            rb.velocity = new Vector2(hor * movespeed * Time.deltaTime, Ver * movespeed * Time.deltaTime);
            if (hor > 0.8 && Ver >0.8)
            {
                MusicManager.PlaySFXsound(MusicManager.WalkingSound1);
            }
        }

        if(rb.velocity.x < 0)
        {
            Capsule.transform.localScale= new Vector2(0.7f,0.55f);
        
        }
        else if(rb.velocity.x > 0)
        {
            Capsule.transform.localScale = new Vector2(-0.7f, 0.55f);
        }


        if(hor != 0.0f&& Ver!=0.0f)
        {
            Animate.SetBool("IsWalking", true);
        }
        else
        {
            Animate.SetBool("IsWalking", false);
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
            Bottom_FrontSide.SetActive(false);
            Top_BackSide.SetActive(false);
            Top_FrontSide.SetActive(false);
            Hidden_BackSide.SetActive(false);
            Hidden_FrontSide.SetActive(false);
            this.gameObject.GetComponent<SortingGroup>().sortingOrder = 0;
            Middle_Cover.SetActive(false);
            Bottom_Cover.SetActive(true);
            Top_Cover.SetActive(false);
            Hidden_Cover.SetActive(true);
            Cupboard_Living.SetActive(true);
            Television.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Bottom"))
        {
            Middle_FrontSide.SetActive(false);
            Middle_BackSide.SetActive(false);
            Bottom_BackSide.SetActive(true);
            Bottom_FrontSide.SetActive(true);
            Top_BackSide.SetActive(false);
            Top_FrontSide.SetActive(false);
            Hidden_BackSide.SetActive(false);
            Hidden_FrontSide.SetActive(false);
            this.gameObject.GetComponent<SortingGroup>().sortingOrder = 3;
            Middle_Cover.SetActive(false);
            Bottom_Cover.SetActive(false);
            Top_Cover.SetActive(true);
            Hidden_Cover.SetActive(true);
            Cupboard_Living.SetActive(false);
            Television.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Top"))
        {
            Middle_FrontSide.SetActive(false);
            Middle_BackSide.SetActive(false);
            Bottom_BackSide.SetActive(false);
            Bottom_FrontSide.SetActive(false);
            Top_BackSide.SetActive(true);
            Top_FrontSide.SetActive(true);
            Hidden_BackSide.SetActive(false);
            Hidden_FrontSide.SetActive(false);
            this.gameObject.GetComponent<SortingGroup>().sortingOrder = -3;
            Top_Cover.SetActive(false);
            Middle_Cover.SetActive(true);
            Bottom_Cover.SetActive(true);
            Hidden_Cover.SetActive(false);
            Cupboard.SetActive(true);
            Television.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Hidden"))
        {
            Middle_FrontSide.SetActive(false);
            Middle_BackSide.SetActive(false);
            Bottom_BackSide.SetActive(false);
            Bottom_FrontSide.SetActive(false);
            Top_BackSide.SetActive(false);
            Top_FrontSide.SetActive(false);
            Hidden_BackSide.SetActive(true);
            Hidden_FrontSide.SetActive(true);
            this.gameObject.GetComponent<SortingGroup>().sortingOrder = -4;
            Top_Cover.SetActive(true);
            Middle_Cover.SetActive(true);
            Bottom_Cover.SetActive(true);
            Hidden_Cover.SetActive(false);
            Cupboard.SetActive(false);
            Television.SetActive(true);
        }
    }
}
