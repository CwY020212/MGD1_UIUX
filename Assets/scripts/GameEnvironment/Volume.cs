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
        Music_slider.value = 0.5f;
        SFX_slider.value = 0.5f;
        Music.volume = 0.5f;
        SFX.volume = 0.5f;
        Ghost.volume = 1.0f;
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
