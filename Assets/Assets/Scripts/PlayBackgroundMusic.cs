using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A small script to play set background music
// Author - Jordan Mccann (23571144)
// Last updated - 11/12/2018

[RequireComponent(typeof(AudioSource))] // Attaches audiosource to object
public class PlayBackgroundMusic : MonoBehaviour {
    private AudioSource src; // audio source
    public AudioClip backgroundMusic; // music

    // when loaded
    void Start()
    {
    	// Set the audio source and it's clip
    	// then play
        src = GetComponent<AudioSource>();
        src.clip = backgroundMusic;
        src.Play();
        src.volume = 0.1f;
    }
}
