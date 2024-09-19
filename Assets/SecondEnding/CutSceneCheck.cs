using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneCheck : MonoBehaviour
{
    private void Update()
    {
        if (this.isActiveAndEnabled)
        {
            SceneManager.LoadScene(0);
        }
    }
}
