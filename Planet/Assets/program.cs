using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class program : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Transform transform = GetComponent<Transform>();
        Vector3 angle = new Vector3(0, 5.0f, 0);
        transform.Rotate(angle);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
