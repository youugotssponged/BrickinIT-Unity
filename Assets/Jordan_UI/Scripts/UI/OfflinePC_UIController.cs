using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfflinePC_UIController : MonoBehaviour {

    public Text pcCountText;
    public static int pcCount = 0;

    void Update()
    {
        pcCountText.text = "PC's OFFLINE: " + pcCount;
    }
}
