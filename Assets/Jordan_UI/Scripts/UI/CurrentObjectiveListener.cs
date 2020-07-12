using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentObjectiveListener : MonoBehaviour {

    public Text ObjectiveText;

	// Use this for initialization
	void Start () {
        ObjectiveText.text = "BRING THE PC'S BACK ONLINE!";
	}
	
	// Update is called once per frame
	void Update () {
        if (OfflinePC_UIController.pcCount == 0)
            ObjectiveText.text = "GET TO THE EXIT!";
	}
}
