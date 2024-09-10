using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retart : MonoBehaviour
{
    public bool RestartCheck;
    public GameObject RestartPanel;

    public void Restart()
    {
        RestartCheck = true;
        RestartPanel.SetActive(true);
    }
}
