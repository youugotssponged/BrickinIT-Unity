using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class ReturnButtonTrigger : MonoBehaviour {

    // Button Attribs
    public AudioClip m_hoverSound;
    public AudioClip m_clickSound;
    private AudioSource m_BtnHoverSource;


    // Use this for initialization
    void Start()
    {
        m_BtnHoverSource = GetComponent<AudioSource>();
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0); // As MainMenu Screen should be 0 in the index list as normal
    }

    public void PlayButtonHoverSound()
    {
        m_BtnHoverSource.clip = m_hoverSound;
        m_BtnHoverSource.volume = 0.8f;
        m_BtnHoverSource.Play();
    }

    public void PlayButtonClickSound()
    {
        m_BtnHoverSource.clip = m_clickSound;
        m_BtnHoverSource.volume = 0.8f;
        m_BtnHoverSource.Play();
    }

}
