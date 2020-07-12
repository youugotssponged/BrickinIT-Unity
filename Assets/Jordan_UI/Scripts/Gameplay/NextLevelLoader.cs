using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelLoader : MonoBehaviour {

    public int nextLevelIndex;

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("TOUCHED!!!!!");
            SceneManager.LoadScene(nextLevelIndex);
        }
    }

}
