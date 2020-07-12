using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code created by Anthony Wilcock - 23702575.
// This code enables all vehicles to move in the game environment. If the car reaches the end point it is then transported back to the start position.

public class Car_1_Movement : MonoBehaviour
{

    public float moveSpeed; // Stores the speed variable for the movement speed of the vehicles.
    public GameObject carStart1; // Stores a game object (empty game object for the cars spawn position).

  void Update ()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime); // Moves the car forwards.
	  }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Car Collider") // If the car collides with a game object with a tag of 'Car Collider'...
        {
            transform.position = carStart1.transform.position; //...Transports the car back to the start position.

        }
    }
}
