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

    public void HowToMovePage()
    {
        Panel1.SetActive(true);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Webpage.text = "Game Movement:" +
            "<br>" +
            "<br>Virtual Joystick:" +
            "<br>Movement" +
            "<br>" +
            "<br>Hand Button:" +
            "<br>Interaction" +
            "<br>" +
            "<br>Phone Button:" +
            "<br>Sabotage and information purpose" +
            "<br>" +
            "<br>Bag Button:" +
            "<br>Inventory system(to check what you get)" +
            "<br>" +
            "<br>Holy Water Button:" +
            "<br>To stun the ghost" +
            "<br>" +
            "<br>Cloask Button:" +
            "<br>To be invisible" +
            "<br>" +
            "<br>Pause Button:" +
            "<br>To adjust overall game setting" +
            "<br>" +
            "<br>" +
            "<br>Game UI Recognization:" +
            "<br>" +
            "<br>Camera Zoom In:" +
            "<br>Penanggal is around you(causing player to be hard to interact with objects)" +
            "<br>" +
            "<br>Yellow Button(Glow):" +
            "<br>Interactable items around you" +
            "<br>" +
            "<br>Connect Button:" +
            "<br>To create distraction in ghost's path" +
            "<br>" +
            "<br>Notes Button:" +
            "<br>To check the game story" +
            "<br>" +
            "<br>Setting Button:" +
            "<br>To adjust In-game setting";

    }
}
