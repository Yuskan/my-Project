using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontroller : MonoBehaviour
{

    public GameObject goldPrefab;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 7; i++)
        {
            float x;
            x = i * 3.5f;
            Instantiate(goldPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
        // Update is called once per frame
        void Update()
        {
        }
    }
}

