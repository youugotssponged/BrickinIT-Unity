using System.IO; // Using standard C# file handling utilities
using UnityEngine;

// A Small File Saving Utility Class
// Author: Jordan McCann
// Student ID: 23571144
// Last Modified: 06/12/18

public class InfoLoader : MonoBehaviour {

    private static string filename = "infosave.json"; // The file name that will be saved
    public static string _path; // A variable to hold the save path and will be made globally available for access between classes

    public static GameInfoData gameInfo = new GameInfoData(); // A gameInfoData object to hold game related information

    public static void CreateInfoFile()
    {
        // Create new File
        try
        {
            SaveInfoFile(); // Save GameInfoData class structure to JSON
            // Check to see if the file saved
            if (!File.Exists(_path)) // If the file did not save
            {
                throw new FileNotFoundException(); // File not found Error
            }
        }
        catch (FileNotFoundException ex)
        {
            Debug.Log(ex.Message); // Print out exception error that was thrown
        }
        
    }
	
    // Loads Information and stores it into the gameInfoObject for ingame use
    public static void LoadInfoFile()
    {
        // Read from the file
        _path = Application.dataPath + "/" + filename; // Set the file path to within the project
        string info = File.ReadAllText(_path);
        // Insert file contents into 
        gameInfo = JsonUtility.FromJson<GameInfoData>(info);
    }

    public static void SaveInfoFile()
    {
        // Take the information stored within the game object
        _path = Application.dataPath + "/" + filename; // Set the file path to within the project
        string info = JsonUtility.ToJson(gameInfo, true);
        // Append the information to the file / Update the file
        File.WriteAllText(_path, info);
    }
    
    

}
