using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HowToKill : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Webpage;
    [SerializeField] private GameObject Panel1;
    [SerializeField] private GameObject Panel2;
    [SerializeField] private GameObject Panel3;
    // Start is called before the first frame update
    public void HowToKillPage()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(true);
        Panel3.SetActive(false);
        Webpage.text = 
            "Nade(Host):     " +
            "<br>Yeah, so what do you think about Penanggal? I heard that in this FizzyCola Town, the Penanggal is especially cruel." +
            "<br>" +
            "<br>Claris:            " +
            "<br>Oh, that's interesting. But unfortunately, I don't know much about it." +
            "<br>" +
            "<br>Claris:            " +
            "<br>Maybe...Yeah, I have heard that she should be not that scaring. That involves lots of black magic things.HAHA." +
            "<br>" +
            "<br>Nade(Host):    " +
            "<br>Black magic huh? (Looking at the audience)" +
            "<br>" +
            "<br>Audience:      " +
            "<br>(Laughters)" +
            "<br>" +
            "<br>Claris:            " +
            "<br>Yeah yeah, I know that's hilarious. But just like men believe that their ****s are longer." +
            "<br>" +
            "<br>Audience:          " +
            "<br>WOOOOOOOOHOOOOOOOOOOOO " +
            "<br>" +
            "<br>Nade(Host):    " +
            "<br>Calm down. Calm down. We ain't going that far. So,don't mind my curiosity." +
            "<br>" +
            "<br>Nade(Host):    " +
            "<br>Are those black magics really existing? You know, we don't think communism exists too, but shit happens huh." +
            "<br>" +
            "<br>Audience:      " +
            "<br>WOOOOOOOOOOOOOOO" +
            "<br>" +
            "<br>Claris:            " +
            "<br>Of coursse a big NO! I'm the sponsor of FizzyCola Racing Cup. We are definitely not agree to see any cheats in the game." +
            "<br>" +
            "<br>Nade(Host):    " +
            "<br>What if, and I mean what if I meet that Penanggal?" +
            "<br>" +
            "<br>Claris:            " +
            "<br>HAHAHA. If there comes the day, then I am the one who is going to drop my tasks. Whatever, just kill her." +
            "<br>" +
            "<br>Nade(Host):    " +
            "<br>With a crucifix? maybe some more holy water?" +
            "<br>" +
            "<br>Audience:      " +
            "<br>(Laughters)" +
            "<br>" +
            "<br>Claris:            " +
            "<br>Yeah yeah. That should be working." +
            "<br>" +
            "<br>Nade(Host):    " +
            "<br>WOWOWOWOWOWOW! Handclaps, fellows!";

    }
}
