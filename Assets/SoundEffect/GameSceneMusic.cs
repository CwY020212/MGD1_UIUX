using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GameSceneMusic : MonoBehaviour
{
    [Header("\t Audio Source \t")]
    [SerializeField] AudioSource Music;
    [SerializeField] AudioSource SFX;
    [SerializeField] AudioSource Ghost;

    [Header("\t Bg Audio Clips \t")]
    public AudioClip Background;
    public AudioClip Background_EndStage;
    public AudioClip Background_Ending;

    [Header("\t SFX Audio Clips \t")]
    public AudioClip DoorLock;
    public AudioClip DoorOpen;
    public AudioClip PickUp;
    public AudioClip Ghost_Roar;
    public AudioClip WalkingSound1;
    public AudioClip WalkingSound2;
    public AudioClip Connected;

    // Start is called before the first frame update
    void Start()
    {
        Music.clip = Background;
        Music.Play();
    }

    public void PlayBackgroundSound(AudioClip clip)
    {
        Music.PlayOneShot(clip);
    }

    public void PlaySFXsound(AudioClip clip)
    {
        SFX.PlayOneShot(clip);
    }

    public void GhostRoar(AudioClip clip)
    {
        Ghost.PlayOneShot(clip);
    }
}
