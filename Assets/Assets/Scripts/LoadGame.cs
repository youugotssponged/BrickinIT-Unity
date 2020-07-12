using UnityEngine;

// A small initial load script to load into the game from the main menu
// Author : Jordan McCann
// Student No: 23571144
// Last Updated: 06/12/18

public class LoadGame : MonoBehaviour {

    public static bool startGame = false; // Used to trigger timer
    public bool MaleOrFemale; // used to decide if the player selected either or..

    public Transform player_pos; // Player's current position
    public Transform selectAreaNode; // used to load player to starting area

    //// Used to test if scene loadscene was working
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        InfoLoader.gameInfo.m_or_f = MaleOrFemale;
    //        InfoLoader.CreateInfoFile(); // Create / Modify info.jsonFile
    //        UnityEditor.SceneManagement.EditorSceneManager.LoadScene(1);
    //    }
    //}

    // On trigger pressed from HTC Vive 
    void OnMVRWandButtonPressed()
    {
        // Set player choice
        InfoLoader.gameInfo.m_or_f = MaleOrFemale;
        InfoLoader.CreateInfoFile(); // Create / Modify info.jsonFile

        // Move the player to the select room
        player_pos.position = selectAreaNode.position;
        startGame = true; // start the timer
		SpawnWeapon.isActive = true;
    }
}