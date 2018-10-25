using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButton : MonoBehaviour {
    public GameObject player;
    PlayerMovement playerController;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<PlayerMovement>();
    }

    private void OnMouseDown()
    {
        playerController.Jump();
    }
}
