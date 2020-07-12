// A Small Information Class to keep track of in game data

// Author: Jordan McCann
// Student ID: 23571144
// Last Modified: 06/12/18

[System.Serializable] // Allows the class to be available for converting into data eg. for text, for json handling
public class GameInfoData { 
    public float time = Timer.timer_timeforFile; // Time
    public int wantedLevel = 0; // Wanted level of the player 0 by default
    public int player_score = 0; // Score of the player 0 by default
    public string current_weapon; // Currently Picked Up Weapon
    public bool m_or_f; // Male or female - true for female, false for male
    public int level_section = 1; // Determines where the player will start each level of the map.
}
