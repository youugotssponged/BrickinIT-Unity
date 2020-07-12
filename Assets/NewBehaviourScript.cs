using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public GameObject Cube;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			if(Input.GetKeyDown(KeyCode.Space)){
				Cube.transform.position = new Vector3(3.0f, 40.5f, 30.5f);
			}
	}
}
