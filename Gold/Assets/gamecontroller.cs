using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour {
    public GameObject goldPrefab;

	// Use this for initialization
	void Start () {
        for(int i = 0; i < 7; i++)
        {
            float x;
            float y;
            x = i * 3.5f;
            x = -10.5f + i * 3.5f;
            y = -10.5f + i * 3.5f;
            Vector3 position = new Vector3(x, y, 0);
            Instantiate(goldPrefab, position, Quaternion.identity);
           
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
