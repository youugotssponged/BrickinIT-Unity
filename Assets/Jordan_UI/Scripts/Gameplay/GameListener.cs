using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameListener : MonoBehaviour {

    public int PC_OFFLINE_COUNT;
    public GameObject EXIT_DOOR;

    private bool isExitDestroyed = false;

	// Use this for initialization
	void Start () {

        // SET UI COMPONENTS ACCORDINGLY
        OfflinePC_UIController.pcCount = PC_OFFLINE_COUNT;
        Timer.CURR_STATE = (int)Timer.GAME_STATE.DEFAULT;
        isExitDestroyed = false;
    }
	
	// Update is called once per frame
	void Update () {

        // CHECK STATES
        // IF WIN - RELEASE ASSOCIATED DOOR
        if (OfflinePC_UIController.pcCount == 0 && !isExitDestroyed)
        {
            isExitDestroyed = true;
            Timer.CURR_STATE = (int)Timer.GAME_STATE.WIN;
            Destroy(EXIT_DOOR);
        }

        // IF OVERALL WIN - LOAD WINSCREEN
        if (Timer.CURR_STATE == (int)Timer.GAME_STATE.WIN_OVERALL_GAME)
            LoadWinScreen();

        // IF LOSE - LOAD LOSE SCREEN AND END THE GAME
        if (Timer.CURR_STATE == (int)Timer.GAME_STATE.LOSE)
            LoadLoseScreen();

	}

    private void LoadLoseScreen()
    {
        SceneManager.LoadScene(4);
    }

    private void LoadWinScreen()
    {
        SceneManager.LoadScene(5);
    }

}
