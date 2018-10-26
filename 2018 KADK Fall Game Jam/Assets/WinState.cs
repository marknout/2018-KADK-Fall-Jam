using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinState : MonoBehaviour {

    public GameObject winObject;
    public GameObject playerObject;

    private void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(winObject, transform.position + new Vector3(0, 1, 0), Quaternion.identity, playerObject.transform);
    }
}
