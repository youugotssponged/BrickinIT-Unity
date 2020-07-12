using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCOFFLINEListener : MonoBehaviour {

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E) && ToolUIController.toolCount > 0)
            {
                OfflinePC_UIController.pcCount--;
                ToolUIController.toolCount--;
                Destroy(gameObject);
            }
        }
    }
}
