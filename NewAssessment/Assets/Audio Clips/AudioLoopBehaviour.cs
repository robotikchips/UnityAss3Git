using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLoopBehaviour : MonoBehaviour
{
    public AudioSource audioSource;     
    public AudioClip firstIntro;        
    public AudioClip normalGhostState;  

    void Start()
    {
        audioSource.clip = firstIntro;
        audioSource.Play();

        Invoke("playNormalGhostState", firstIntro.length);
    }

    void playNormalGhostState()
    {
        audioSource.clip = normalGhostState;
        audioSource.Play();
    }
}

