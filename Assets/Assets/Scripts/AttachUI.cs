using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// - Last Updated : 8/12/2018
// UI attachment script to solve middleVR problem of attaching the UI to the HEADNODE on initialization

public class AttachUI : MonoBehaviour 
{
	// When the script is loaded
    void Start()
    {
    	// Set the current object - in this case the hud canvas
    	// To the HeadNode as it's parent
        transform.parent = GameObject.Find("HeadNode").transform;
    }
}
