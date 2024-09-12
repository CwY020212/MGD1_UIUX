using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public AudioSource Music;
    public AudioSource SFX;
    public AudioSource Ghost;
    public Slider Music_slider;
    public Slider SFX_slider;

    private void Start()
    {
        Music_slider.value = 1;
        SFX_slider.value = 1;
    }

    public void MusicVolume()
    {
        Music.volume = Music_slider.value;
    }

    public void SFXvolume()
    {
        SFX.volume = SFX_slider.value;
        Ghost.volume = SFX_slider.value;
    }
}
