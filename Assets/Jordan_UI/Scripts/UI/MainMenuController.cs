using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using UnityEditor;

[RequireComponent(typeof(AudioSource))]
public class MainMenuController : MonoBehaviour {

    // Logo Atrributes
    public Image logo;
    private double fl = 2;
    private bool shouldMoveUp = true;

    // Button Attribs
    public AudioClip m_hoverSound;
    public AudioClip m_clickSound;
    private AudioSource m_BtnHoverSource;
    

	// Use this for initialization
	void Start () {
        m_BtnHoverSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        logo.rectTransform.position = new Vector2
        (
            logo.rectTransform.position.x, 
            logo.rectTransform.position.y + (float)fl
        );

        CheckFloatingImage();

    }

    private void CheckFloatingImage()
    {
        if (shouldMoveUp == false)
        {
            if (fl == -4)
                shouldMoveUp = true;
            fl = fl - 0.25;

        }

        else if (shouldMoveUp)
        {
            if (fl == 4)
                shouldMoveUp = false;
            fl = fl + 0.25;
        }
    }

    // Used in tandem with the event system
    // Functions for external use
    // Button Behaviours

    /// <param name="isDebug">
    ///     true = debug - quits the unity editor quits the application
    ///     false = quits the application
    /// </param>
    public void QuitGame()
    {
        // If Debugging is on / In Editor - Stop Playing
        //if (isDebug)
        //    UnityEditor.EditorApplication.isPlaying = false;
        //else
            Application.Quit(); // Quit The Executable Application in Release mode
    }

    public void LoadGame(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void LoadInfoScreen(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0); // As MainMenu Screen should be 0 in the index list as normal
    }

    // Overloaded ^
    public void LoadMainMenu(int index)
    {
        SceneManager.LoadScene(index);
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
