using UnityEngine;
// A small script to be used by MiddleVR to exit the game upon the players request
// Author : Jordan McCann
// Student No: 23571144
// Last Updated: 06/12/18


public class Button3_OnClick : MonoBehaviour {

    public bool isEditorUsed; // To toggle between editor and release check

    // When trigger pressed
    void OnMVRWandButtonPressed()
    {
         //If in editor
        if (isEditorUsed)
        {
           // Stop the editor play instance
           UnityEditor.EditorApplication.isPlaying = false;
        }
        else // Or
        {
            // Exit the game application 
            Application.Quit();
        }
    }

}
