using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    void Update()
    {
        gameObject.transform.Rotate(0f, 0f, 2f);
    }

    void OnTriggerStay(Collider col)
    {
        if(col.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(gameObject);
                ToolUIController.toolCount++;
            }
        }
    }
}
