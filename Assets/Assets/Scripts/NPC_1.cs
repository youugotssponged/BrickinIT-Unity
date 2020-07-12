using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Code created by Anthony Wilcock - 23702575
// This code enables the NPC game object to forwards towards a patrol point. Whenever the NPC reaches a patrol point, it turns 180° and moves towards the next way point.
// Last updated 13/12/2018.

public class NPC_1 : MonoBehaviour
{
    
    public Transform[] patrolPoints; // Array of waypoints that can be set in the inspector.

    private int currentPatrolPoint; // Stores the value of the current patrol point.
    private float moveSpeed = 2; // NPC movement speed.

    // Update is called once per frame
    void Update ()
    {
        patrol (); // Calls the patrol function.
    }

    void patrol ()
    {
        // moves NPC to the next patrol point.
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPatrolPoint].position, moveSpeed * Time.deltaTime); 

        if (transform.position == patrolPoints[currentPatrolPoint].position) // if NPC has reached a patrol point...
        {
            transform.Rotate(0f, 180f, 0f); // Rotates the NPC object 180 degrees.
            currentPatrolPoint++; // add 1 to current point.
        }

        if (currentPatrolPoint >= patrolPoints.Length) // if NPC has reached last point...
        {
            currentPatrolPoint = 0; // NPC walks back to first point.
        }
    }
}
