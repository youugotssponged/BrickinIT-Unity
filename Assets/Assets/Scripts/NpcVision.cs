using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 
 * @author: Antony Bennett, 21119996
 * @author: Jordan Mccann, 23571144
 * 
 * @about:  When the player collides with a trigger component attached to an object
 *          with the tag VisionCone, the player hears an audio cue and the wanted level
 *          increases by one.
 *          
 *          All sound scripting was implemented by Jordan Mccann, 23571144.
 *          
 *          All other scripting was implemented by Antony Bennett, 23571144.
 *          
 * Last Updated: 11/12/2018 by Antony Bennett
 * 
 */

// Adds an audio source component automatically to the object when this script
[RequireComponent(typeof(AudioSource))]

public class NpcVision : MonoBehaviour {

  // Variables used
  private AudioSource _audioSource; // Used to store the audio source
  public AudioClip wantedSound; // Used to access the audio clip attached to this script

  // Updates once at start
  // set the sound clips used when the player collides with an NPC vision cone
  void Start() {

    // Get the audio source attached to this object
    _audioSource = GetComponent<AudioSource>();

    _audioSource.clip = wantedSound;

  }

  /*
   * 
   * @method OnTriggerEnter:  When the player collides with a collider with the tag
   *                          VisionCone, then the player will hear a warning cue and
   *                          increases the wanted level of the player by one.
   * 
   * @param:  Collider other: detects when the player collides with an 
   *                          NPC vision cone trigger.
   * 
   */
  void OnTriggerEnter(Collider other) {

    // If the player collides with an object with the tag VisionCone, an audio cue is
    // sounded and the player wanted level is increased by one.
    if (other.gameObject.tag == "VisionCone") {

      _audioSource.PlayOneShot(_audioSource.clip); // Play sound clip.

      Debug.Log(InfoLoader.gameInfo.wantedLevel); // Debug log for testing

      Debug.Log("You are Seen!"); // Debug log for testing

      // Access the Json file through the gameInfo variable in the InfoLoader script.
      InfoLoader.gameInfo.wantedLevel += 1; // Increase wanted level by one.

      

    }

  }

}
