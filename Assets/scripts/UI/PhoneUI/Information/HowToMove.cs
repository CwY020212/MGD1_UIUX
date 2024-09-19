using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HowToMove : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Webpage;
    [SerializeField] private GameObject Panel1;
    [SerializeField] private GameObject Panel2;
    [SerializeField] private GameObject Panel3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HowToMovePage()
    {
        Panel1.SetActive(true);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Webpage.text = "Game Movement:" +
            "<br>" +
            "<br>Virtual Joystick   -   Movement" +
            "<br>Hand Button        -   Interaction" +
            "<br>Phone Button       -   Sabotage and information purpose" +
            "<br>Bag Button         -   Inventory system(to check what you get)" +
            "<br>Holy Water Button  -   To stun the ghost" +
            "<br>Cloask Button      -   To be invisible" +
            "<br>Pause Button       -   To adjust overall game setting" +
            "<br>" +
            "<br>Game UI Recognization:" +
            "<br>" +
            "<br>Red Screen         -   Penanggal is around you(causing player to be hard to interact with objects)" +
            "<br>Yellow Button(Glow)-   Interactable items around you" +
            "<br>Connect Button     -   To create distraction in ghost's path" +
            "<br>Notes Button       -   To check the game story" +
            "<br>Setting Button     -   To adjust In-game setting";

    }
}
