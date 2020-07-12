using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PauseMenuListener : MonoBehaviour {

    public GameObject m_PauseMenuCanvasObj = null;
    private bool isPaused = false;

    // Button Attribs
    public AudioClip m_hoverSound;
    public AudioClip m_clickSound;
    private AudioSource m_BtnHoverSource;

    // Use this for initialization
    void Start ()
    {
        //Time.timeScale = 1.0f; // Enforce normal timescale by default
        m_BtnHoverSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
                PauseGame();
            else
                ResumeGame();
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0.0f; // Freeze engine time, halting everything
        isPaused = true;
        m_PauseMenuCanvasObj.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1.0f;
        isPaused = false;
        m_PauseMenuCanvasObj.SetActive(false);
    }

    public void ReturnMainMenu()
    {
        Time.timeScale = 1.0f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
         Application.Quit();
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
