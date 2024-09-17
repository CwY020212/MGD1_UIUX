using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEditor.Search;
using UnityEngine;

public class StaticData : MonoBehaviour
{
    public static float brightness = 50;

    public static int diff; //0 = ez, 1 = normal, 2 = hard

    //items
    public static bool HolyWater;
    public static bool Crucifix;
    public static bool Salt;
    public static bool Pepper;
    public static bool Hammer;
    public static bool Key1;
    public static bool Key2;
    public static bool Key3;
    public static bool Key4;
    public static bool HiddenKey;


    //notes
    public static bool Note1 = false;
    public static bool Note2 = false;
    public static bool Note3 = false;
    public static bool Note4 = false;
    public static bool Note5 = false;
    public static bool Note6 = false;
    public static bool Note7 = false;
    public static bool Note8 = false;
    public static bool Note9 = false;
    public static bool Note10 = false;
    public static bool Note11 = false;
    public static bool Note12 = false;
    public static bool Note13 = false;
    public static bool Note14 = false;

    //public static bool Note1 = true;
    //public static bool Note2 = true;
    //public static bool Note3 = true;
    //public static bool Note4 = true;
    //public static bool Note5 = true;
    //public static bool Note6 = true;
    //public static bool Note7 = true;
    //public static bool Note8 = true;
    //public static bool Note9 = true;
    //public static bool Note10 = true;
    //public static bool Note11 = true;
    //public static bool Note12 = true;
    //public static bool Note13 = true;
    //public static bool Note14 = true;

    //abilities
    public static bool TV;
    public static bool Radio;
    public static bool Cloak;

    //Status
    public static bool isHiding;

    public static bool TimerInWork;
    public static float minutes = 0.0f;
    public static float seconds = 10.0f;
    public static float timer = minutes + seconds;
    public static bool TelevisionInWork = false;
    public static bool TelevisionInRing = false;
    public static bool TelevisionInCD = false;
    public static bool RadioInWork = false;
    public static bool RadioInRing = false;
    public static bool RadioInCD = false;


    public static int BatteryLife = 50;
    public static int BatterPerUse = 5;

    public static bool Difficulty = false;

    public static bool isPaused= false;

    public static string LineToBeShown;

    public static int GameStage =1; //1 for First, 2 for End

}
