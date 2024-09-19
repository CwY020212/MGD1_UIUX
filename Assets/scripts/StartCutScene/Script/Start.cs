using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
    public GameObject flowchart;
    public GameObject flowChart_Button;
    public Animator title_animator;

    public AudioSource Music;
    public void Title()
    {
        title_animator.SetBool("Clicked", true);
        flowChart_Button.SetActive(false);
        StartCoroutine(startGame());
    }

    IEnumerator startGame()
    {
        yield return new WaitForSeconds(5.0f);
        flowchart.SetActive(true);
        Music.Stop();
        
    }
}
