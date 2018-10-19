using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour {

    public bool isCorrect;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {
        if (isCorrect)
        {
            GetComponent<TextMesh>().color = Color.green;
        }
        else
        {

            GetComponent<TextMesh>().color = new Color(17, 79, 47, 255);
            GetComponent<TextMesh>().color = Color.red;
        }
    }

}
