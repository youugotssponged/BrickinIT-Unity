using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A small script to be used by MiddleVR to move the player to the instructions area of the main menu
// Author : Jordan McCann
// Student No: 23571144
// Last Updated: 06/12/18


public class Button2_OnClick : MonoBehaviour {

    public Transform player_pos; // Player's current position
    public Transform instructions_area_node; // Node to the instructions room from the main menu

    // When trigger pressed - HTC VIVE 
    void OnMVRWandButtonPressed()
    {
        // Move the player to the instructions room
        player_pos.position = instructions_area_node.position;
    }
}
