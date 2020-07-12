using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ToolUIController : MonoBehaviour {

    public Text toolCountText;
    public static int toolCount = 0;

	void Update () {
        toolCountText.text = "Tools collected: " + toolCount;
	}
}
