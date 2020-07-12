using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MainMenuThemeTrigger : MonoBehaviour {

    private AudioSource m_themeSource;
    public AudioClip m_theme;

	// Use this for initialization
	void Start () {
        m_themeSource = GetComponent<AudioSource>();
        m_themeSource.clip = m_theme;
        m_themeSource.volume = 0.15f;
        m_themeSource.loop = true;
        m_themeSource.Play();
    }
}
