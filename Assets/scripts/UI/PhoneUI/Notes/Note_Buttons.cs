using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Note_Buttons : MonoBehaviour
{
    private const string Note = "Note";
    private string Change;
    [SerializeField] private GameObject Canvas;
    [SerializeField] private TextMeshProUGUI NotePage;
    [SerializeField] private GameObject NotePageGO;
    [SerializeField] private GameObject CloseNotePage_Button;
    [SerializeField] private GameObject CloseTab;


    public void Note_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note1 == true)
        {   
            Canvas.SetActive(true);
            NotePage.text = 
                "20XX/06/15" +
                "<br>For those who come back. Last Warning" +
                "<br>This house is abandoned, and our only task is done." +
                "<br>Shut your mouth up to the unbelievers." +
                "<br>Burn this note and leave here.";
            StaticData.LineToBeShown = "Lighter x 1";
        }
    }

    public void Note2_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note2 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = 
                "Name : Savir" +
                "<br>Age : 26" +
                "<br>Sex : F" +
                "<br>Reason : " +
                "<br>   She's just a fucked up piece of shit. " +
                "She was just trying to ruin our lives by winning the trophy using some ugly and annoying black magics" +
                "<br>She deserved to be here.";
        }
    }

    public void Note3_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note3 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = "200X/04/20" +
                "<br>She is just sitting in front of the TV for whole day. I wonder-/-/-/-/-/-/-/" +
                "<br>I closed the TV just now, and she left." +
                "<br>She even now is trying to learn some racing things from that stupid TV." +
                "That TV is kinda complicated, and she's from outside." +
                "<br>She must be doing some stuff that we can't understand to tell Mark." +
                "<br>Sad Mark.";
        }
    }

    public void Note4_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note4 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = "200X/05/16" +
                "<br>Now she is eating. Marson told me to leave her to be hungry." +
                "<br>They wanted to do something." +
                "<br>She's getting used to her life now. That's a good news." +
                "She'll know when she was trying to steal our lives, " +
                "the real problems that we've tasted ain't that tasty.";
        }
    }
    public void Note5_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note3 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = "200X/05/20" +
                "<br>A nice day I see. Jalden is so smart lol." +
                "He can find a place like this that none of us know about here." +
                "<br>Best Place Ever." +
                "<br>I wish to see Mark's face. His face must be funny lol." +
                "Look at his wife now, another naked stupid bitch here." +
                "<br>A stupid woman with a useless man." +
                "<br>Yeah." +
                "<br>Best Place Ever.";
        }
    }
    public void Note6_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note6 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = "200X/05/22" +
                "<br>Mark just came to here LOLLLLLLLLLLLLLLLLLL" +
                "<br>He was just literally standing inside of the house but not aware of his bitch." +
                "<br>Watching that was so much funniner than taking care of this." +
                "<br>Luckily though, that bitch started to walk around in the house." +
                "Marson had told me that there won't be any place for that bitch to hide herself," +
                "but still, it can be dangerous what if Mark finds out what's happening here." +
                "<br>I'd better tell Claris to make him stay on a position." +
                "<br>A policeman should be fine.";
        }
    }
    public void Note7_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note7 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = "200X/06/15" +
                "<br>It can be really boring to stay at here, so I get another fantasy thing from her house to here." +
                "<br>But, how comes this motherfucker has such complicated thing in her house, and this is not even about racing." +
                "Jalden said that this must be the secret those motherfuckers've been hiding before." +
                "<br>It is so complicated that I see how they won the racing trophy with some simple steps." +
                "<br>Black magics huh? Yeah." +
                "<br>You shit unbeliever.";
        }
    }
    public void Note8_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note8 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = "200X/06/17" +
                "<br>Finally! Marson is ready for the work." +
                "<br>Now we are letting that bitch to have her own redemption.";
        }
    }
    public void Note9_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note9 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = "200X/09/01" +
                "<br>It takes weeks." +
                "<br>It takes /-/weeks." +
                "<br>It takes weeks." +
                "<br>It take-/-/-/s weeks." +
                "<br>It takes weeks." +
                "<br>It takes w/-/-/-/eeks." +
                "<br>It t-/-/-/-akes weeks." +
                "<br>It takes wee-ks." +
                "<br>It tak-/-/-//-es weeks." +
                "<br>I/-t ta/-kes /-//weeks." +
                "<br>I/-/t tak-/es wee/-/--ks." +
                "<br>I-/t/// takes/ wee////ks." +
                "<br>It take'[-0/0s 0--/9--/eeks." +
                "<br>It- /-/-takes/-0/['; wee/-/-ks." +
                "<br>and no-/-/-/w, FINA-/-LLY-/-/-/-/-/-/-/-";

        }
    }
    public void Note10_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note10 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = "Marson:" +
                "<br>I'm writing this not for other purposes." +
                "<br>I wonder which step was I wrong? Those steps should have not been wrong." +
                "I have done exactly like Claris said though, that woman just will not turn into Penanggal." +
                "<br>I should have made it without hesitation, but it comes out that it seems to be too late." +
                "That woman is 'stopped', from every view. Her time, her body, her blood, her mind, and most likely her soul." +
                "<br>I can't do anything else to that woman already. Maybe we should just stop here before it is too late." +
                "<br>I'm sure that you won't say yes easily, so forgive me only leaving a letter to you." +
                "<br>" +
                "<br>From " +
                "<br>Jalden";
        }
    }
    public void Note11_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note11 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = "Phone" +
                "<br>Words" +
                "<br>From End" +
                "<br>To Beginning";
        }
    }
    public void Note12_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note12 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = "Jalden - Lost" +
                "<br>Jack - Lost" +
                "<br>Marson - -/-/-/-/" +
                "<br>Claris - -/--/-/-/-///" +
                "<br>Brekham - Lost" +
                "<br>Srad - ---////-/-/-/" +
                "<br>Monk - ///-/-/-///" +
                "<br>Criss - Lost" +
                "<br>LZY - Lost" +
                "<br>Terr - Lost" +
                "<br>Chekin - /-//-';'-/';;'-/" +
                "<br>Tvon - -/-/-/--/--//" +
                "<br>LWX - ---/-/-/-/-/";
        }
    }
    public void Note13_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note13 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = "Jack was making these notes. From the amount I can see that he loved to write things." +
                "<br>I'm hiding one of the papers here." +
                "<br>There should always be something left behind." +
                "<br>People." +
                "<br>And that's always because something that someone had done." +
                "<br>The beginning was the reason I am here.";
        }
    }
    public void Note14_OnButtonClick()
    {
        NotePageGO.SetActive(true);
        CloseTab.SetActive(false);
        CloseNotePage_Button.SetActive(true);
        if (StaticData.Note14 == true)
        {
            Canvas.SetActive(true);
            NotePage.text = "I love you";
        }
    }
}

