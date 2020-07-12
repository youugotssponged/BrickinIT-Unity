using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * @author:  Antony Bennett, 21119996
 *           Jordan McCann, 23571144
 *           
 * @about: Script to check in game conditions to be met by the player which in turn, expands their play area
 *         allowing them to get more points along with the challenge of not being spotted by police AI NPC           
 *           
 * Last Updated : 11/12/2018
 */
public class CheckGameConditions : MonoBehaviour {

	public static bool timeLock = true; // Helps to stop the timer from constantly increasing via every frame from update
	
	// Update is called once per frame
	void Update () {

    // If the player's score is 800, remove 1st barrier to expand level
    // Implemented by Antony Bennett, 21119996.
    if (InfoLoader.gameInfo.player_score == 800) { 

      // Finds the object with the name "Level01 Barrier" and destroy it
      Destroy(GameObject.Find("Level01 Barrier")); // Delete barrier 
      
			// Jordan McCann - 23571144 - Time Lock
			if(timeLock) { // If timer incrementing isn't locked

				Timer.duration += 180; // Add three mins

				timeLock = false; // Lock

			}

    }

    // If the player's score is 5000, remove 2st barrier to expand level
    // Implemented by Antony Bennett, 21119996.
    if (InfoLoader.gameInfo.player_score > 5000 && InfoLoader.gameInfo.player_score < 5200) { 

      // Finds the object with the name "Level02 Barrier" and destroy it
      Destroy(GameObject.Find("Level02 Barrier"));// Delete barrier 

			// Jordan McCann - 23571144 - Time Lock
			if(timeLock){ // If timer incrementing isn't locked

				Timer.duration += 120; // Add two mins

				timeLock = false; // Lock

			}

    }

  }

}
