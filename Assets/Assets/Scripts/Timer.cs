using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Accessing UI components

// A small timer script based off Coroutines usage for waiting frames
// Author : Jordan McCann
// Student No: 23571144
// Last Updated: 06/12/18

public class Timer : MonoBehaviour {

    public Text timer_Text; // Used to update UI timer text
    public static float duration = 120; // 2 mins to begin with
    private string time_string; // used to hold the string representation of the time

    public static float timer_timeforFile; // Used to pull saved time from json file if needed

    // Check if timer has been triggered yet
    void Update()
    {
        // If timer started / game started
        if(LoadGame.startGame == true)
        {
            // Start the timer
            StartCoroutine("_Timer");
			LoadGame.startGame = false; // Stop checking
        }
    }

    // Timer coroutine function
    private IEnumerator _Timer()
    {
        // While time more than 0 in this case
		while (duration >= 0f)
		{
			int mins = (int)(duration / 60); // Convert to mins
			int seconds = (int)(duration % 60); // Convert to sections
			time_string = string.Format("{0:00} : {1:00}", mins, seconds); // Format string into readible time

			timer_Text.text = time_string; // Update the UI time text
			duration -= 1f; // Decrease time by one second

			timer_timeforFile = duration; // update file time if needed

			yield return new WaitForSeconds(1); // Wait for 1 second then loop
		}
    }

}
