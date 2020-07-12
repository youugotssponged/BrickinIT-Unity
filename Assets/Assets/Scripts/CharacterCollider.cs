using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Created by Anthony Wilcock - 23702575.
// This code is created for a collision between the player character and a vehicle.
// Whenever a game object with the tag 'Car' collides with the player, the player would then respawn to the start position.

public class CharacterCollider : MonoBehaviour
{
  
    public Transform playerPos; // Stores the position of the player
    public Transform spawnPos; // Stores the position of the spawn point for the player when collides with cars.
  
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Car") // If the player collides with a car...
        {
            StartCoroutine(wait()); // Starts the coroutine.
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(2); // Wait for 2 seconds before doing rest of code.
        playerPos.position = spawnPos.position; // Transports the player to the spawn position.
    }
}
