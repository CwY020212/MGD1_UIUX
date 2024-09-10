using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Difficulty_Dropdown : MonoBehaviour
{
    public int Choice;
    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private GameObject Check_Panel;

    public void GetDropDownValue()
    {
        Choice = dropdown.value;
        if (Choice != StaticData.diff)
        {
            Check_Panel.SetActive(true);
        }
        dropdown.value = Choice;

    }
}
