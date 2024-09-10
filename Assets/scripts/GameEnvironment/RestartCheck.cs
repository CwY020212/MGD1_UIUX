using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartCheck : MonoBehaviour
{
    public Retart Restart;

    public void restartEnsure()
    {
        if (Restart.RestartCheck)
            SceneManager.LoadScene(2);

    }
    
    public void restartDeny()
    {
        Restart.RestartPanel.SetActive(false);
    }
}
