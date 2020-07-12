using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
- Authors:  - Jordan McCann (23571144)
            - Jordan Nash (23719613)

- Last Updated : 10/12/2018
*/

// Window Collision Script to deal with allocation of points 
// and deletion of windows to simulate a smash by the player.

// Ensures that when this script is attached, a AUDIO SOURCE component is also added to the object by default
[RequireComponent(typeof(AudioSource))]
public class WeaponWindowCollision : MonoBehaviour {

    private bool isActive = true; // used as a switch to stop the script from accessing the object - stops NULLREF Exception

    public AudioClip glassSmashSound; // Glass smash sound effect
    public AudioClip pointSound; // Point gained sound effect
    private AudioSource src; // The AudioSource component to play the audio clips

    // Check Collision
    //- Jordan Nash (21119996) - Collision check, Score increase, Window deletion
    //- Jordan McCann (23571144) - isActive check to avoid nullref exception, Audio playing and clip reseting
    private void OnCollisionEnter(Collision collision)
    {
        // If the player has smashed a window using one of the two weapons
        if (collision.gameObject.tag == "Brick" || collision.gameObject.tag == "Bottle")
        {
            // Check if still active
            if (isActive)
            {
                src.Play(); // Play smash sound
                Debug.Log("Smashhhh..."); // Debug purposes
				        InfoLoader.gameInfo.player_score += 100; // Increment score by 100 points - using the inbuilt static gameInfo instance
                //src.clip = pointSound; // Switch clip
                //src.PlayOneShot(src.clip); // Play point gained clip
                Destroy(gameObject); // Delete the window to simulate a smash
                
                //src.clip = glassSmashSound; // Reset back to smash sound
                isActive = false; // No longer active as the window this script as been attached to is gone
            }
            
        }
    }

    // Jordan McCann (23571144) - Start method initialisation
    // Used to set initial components
    void Start()
    {
        src = GetComponent<AudioSource>(); // Access audio source attached to this object
        src.clip = glassSmashSound; // Set the initial sound to smash sound
        src.volume = 0.7f; // Set the volume loud enough so the player can audibly hear
    }
}
