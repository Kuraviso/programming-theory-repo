using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : PlayerController
{
    private Vector3 fighterMisileOffset = new Vector3(5f, 0f, 1f);

    // Start is called before the first frame update
    void Start()
    {
        // setting the variables for the parent class.
        playerSpeed = 100;
        playerMisileOffset = fighterMisileOffset;
    }

    // Update is called once per frame
    void Update()
    {
        // call the methods to move the player
        CharacterMovement();

        // if space is pressed then shoot misiles.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootMisiles();

        }

    }
}
