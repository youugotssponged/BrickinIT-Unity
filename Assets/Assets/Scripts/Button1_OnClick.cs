using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A small script to be used by MiddleVR to move the player to the selection area of the main menu
// Author : Jordan McCann
// Student No: 23571144
// Last Updated: 06/12/18


public class Button1_OnClick : MonoBehaviour {

    public Transform player_pos; // Player's current position
    public Transform selectAreaNode; // Node to the select room from the main menu for the player to chose a gender to start the game

	// When trigger pressed - HTC VIVE 
    void OnMVRWandButtonPressed()
    {
        // Move the player to the select room
        player_pos.position = selectAreaNode.position;
    }
}
