using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildLevel : MonoBehaviour {

    public int numberOfChunks = 10;
    public GameObject[] chunks;
    int chunkWidth = 20;

	// Use this for initialization
	void Start () {
        for (int i = 1; i <= numberOfChunks; i++)
        {
            Instantiate(chunks[Random.Range(0,chunks.Length)], transform.position + new Vector3(i * chunkWidth, 0, 0), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
