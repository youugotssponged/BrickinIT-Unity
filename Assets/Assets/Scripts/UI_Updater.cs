using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Accessing Unity's UI components

/*
- Authors:  - Jordan McCann (23571144)
            - Jordan Nash (23719613)

- Last Updated : 11/12/2018
*/

// Script to keep the user's HUD UI updated with information as it happens realtime in game
public class UI_Updater : MonoBehaviour {
	public Text ui_scoreText; // score text reference
	public Text final_score_lose; // Score text for lose area
	public Text final_score_win; // Score text for win area
	public Text weaponText; // current weapon text
	
	public Image want1, want2, want3, want4, want5; // Wanted Level stars to be accessed

	public Transform playerpos; // Player's current position
	public Transform losepos; // Lose area spawn
	public Transform winPos; // Win area spawn

	void Start(){
		// Create json file incase one isn't present as the game starts
		InfoLoader.CreateInfoFile();
	}
	
  // Update is called once per frame
  void Update () {
		// Update player's score on the UI
		ui_scoreText.text = InfoLoader.gameInfo.player_score.ToString();
		
		// Update Current Weapon that the player is allocated
		weaponText.text = InfoLoader.gameInfo.current_weapon;
		
		// If the wanted level is 0
		if(InfoLoader.gameInfo.wantedLevel == 0){
			// Hide all wanted stars
			want1.enabled = false;
			want2.enabled = false;
			want3.enabled = false;
			want4.enabled = false;
			want5.enabled = false;
		}
		
		// If the player gain's an additional wanted star
		if(InfoLoader.gameInfo.wantedLevel == 1){
			// Show one wanted star
			want1.enabled = true;
		}
		
		// If the player gain's an additional wanted star
		if(InfoLoader.gameInfo.wantedLevel == 2){
			// Show one wanted star
			want2.enabled = true;
		}
		
		// If the player gain's an additional wanted star
		if(InfoLoader.gameInfo.wantedLevel == 3){
			// Show one wanted star
			want3.enabled = true;
		}

		// If the player gain's an additional wanted star
		if(InfoLoader.gameInfo.wantedLevel == 4){
			// Show one wanted star
			want4.enabled = true;
		}
		
		// If the player gain's an additional wanted star
    // Player transition to lose screen implemented by Jordan Nash, 23719613
		if(InfoLoader.gameInfo.wantedLevel == 5){
			// Show one wanted star
			want5.enabled = true;
			InfoLoader.SaveInfoFile(); // Save score etc to json
			playerpos.position = losepos.position; // move the player to the lose area
			InfoLoader.LoadInfoFile(); // load saved info
			final_score_lose.text = InfoLoader.gameInfo.player_score.ToString(); // Set the lose area final score
		}

    // If the timer runs out, the player wins as they successfully have not been spotted / ran out of chances - wanted level
    // Player transition to win screen implemented by Jordan Nash, 23719613
    if (Timer.duration == 0f){
			InfoLoader.SaveInfoFile();// Save score etc to json
			playerpos.position = winPos.position;// move the player to the win area
			InfoLoader.LoadInfoFile();// load saved info
			final_score_win.text = InfoLoader.gameInfo.player_score.ToString();// Set the win area final score
		}
		
	}
}
