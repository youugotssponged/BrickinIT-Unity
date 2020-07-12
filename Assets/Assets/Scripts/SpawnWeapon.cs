using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *
 * @author: Antony Bennett, 21119996
 * 			Jordan Mccann, 23571144
 *
 * @about: 	Spawn a botttle or brick as the main weapon of choice for the main character, defined by the gender selected
 *		  	(bottle for female and brick for male).
 *
 * Last Updated: 12/12/2018 by Antony Bennett
 */

public class SpawnWeapon : MonoBehaviour {

  public GameObject brick; // Variable for game object Brick
  public GameObject bottle; // Variable for game object Bottle
 
  public static bool isActive; // Used to limit the call in Update() to only once
	
	// Update is called once per frame
	void Update () {
		
		// If the player chooses female AND the isActive boolean is true spawn a bottle prefab
		// and sets the current weapon in the UI to display "Bottle". Sets the isActive boolean to
		// false to stop calling the if statement and limiting the number of objects spawned to one.
		if (InfoLoader.gameInfo.m_or_f == true && isActive) {
				
				// Implemented by Antony Bennett, 21119996
				Instantiate(bottle); // Spawns a bottle.
				
				// Implemented by Jordan Mccann, 23571144.
				InfoLoader.gameInfo.current_weapon = "Bottle"; // Changes UI interface for current weapon.
				
				// Implemented by Antony Bennett, 21119996
				isActive = false; // set to false to limit Update call.
    	}
		
		// Same as above but spawns a Brick instead of a bottle
		if (InfoLoader.gameInfo.m_or_f == false && isActive) {
			
			// Implemented by Antony Bennett, 21119996
			Instantiate(brick); // Spawns a brick
			
			// Implemented by Jordan Mccann, 23571144.
			InfoLoader.gameInfo.current_weapon = "Brick"; // Changes UI interface for current weapon.
			 
			// Implemented by Antony Bennett, 21119996
			isActive = false; // set to false to limit Update call.
		}
	}
}
