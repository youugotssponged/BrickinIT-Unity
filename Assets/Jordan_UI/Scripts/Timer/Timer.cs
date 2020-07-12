using System.Collections;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    public Text t_text;
    private string t_string;

    public float duration = 120; // 2 MINS

    private bool hasStarted = true;

    public static int CURR_STATE;

    public enum GAME_STATE
    {
        WIN = 0,
        WIN_OVERALL_GAME,
        LOSE,
        DEFAULT
    }
	
	// Update is called once per frame
	void Update () {
        if (hasStarted)
        {
            StartCoroutine("_Timer");
            hasStarted = false;
        }
	}

    private IEnumerator _Timer()
    {
        while(duration > 0f)
        {
            int mins = (int)duration / 60;
            int seconds = (int)duration % 60;

            t_string = string.Format("{0:00} : {1:00}", mins, seconds);
            t_text.text = t_string;

            duration -= 1f;

            yield return new WaitForSeconds(1);
        }

        // IF THE TIMER HAS RAN OUT, DEFAULT TO LOSE STATE
        CURR_STATE = (int)GAME_STATE.LOSE;

    }
}
