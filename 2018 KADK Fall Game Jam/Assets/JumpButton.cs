using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpButton : MonoBehaviour {
    public GameObject player;
    PlayerMovement playerController;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<PlayerMovement>();
    }

    private void TriggerJump()
    {
        playerController.Jump();
    }
}
