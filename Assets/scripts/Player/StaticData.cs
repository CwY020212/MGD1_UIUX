using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEditor.Search;
using UnityEngine;

public class StaticData : MonoBehaviour
{
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


    //notes
    public static bool Note1;
    public static bool Note2;
    public static bool Note3;
    public static bool Note4;
    public static bool Note5;
    public static bool Note6;
    public static bool Note7;
    public static bool Note8;
    public static bool Note9;
    public static bool Note10;
    public static bool Note11;
    public static bool Note12;
    public static bool Note13;
    public static bool Note14;

    //abilities
    public static bool TV;
    public static bool Radio;
    public static bool Statue = true;
    public static bool Cloak;
    public static bool Mimicking;

    //Status
    public static bool isHiding;
    public static bool isStatue;

    public static bool TimerInWork;
    public static float minutes = 0.0f;
    public static float seconds = 10.0f;
    public static float timer = minutes + seconds;
    public static bool TelevisionInWork = false;
    public static bool RadioInWork = false;

    public static int BatteryLife = 50;
    public static int BatterPerUse = 5;

    public static bool Difficulty = false;

    public static bool isPaused= false;

}
