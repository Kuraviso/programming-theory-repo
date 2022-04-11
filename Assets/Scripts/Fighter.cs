using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : PlayerController
{


    private AudioSource misileSound;

    private Vector3 fighterMisileOffset = new Vector3(5f, 0f, 5f);

    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;

        misileSound = GetComponent<AudioSource>();
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
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            ShootMisiles();
            misileSound.PlayOneShot(misileSound.clip, 1f);

        }

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Ally"))
        {

            Instantiate(explosionParticle, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            GameOver();


        }
        else if (collision.gameObject.CompareTag("Misile"))
        {


            Instantiate(explosionParticle, transform.position, Quaternion.identity);
            collision.gameObject.SetActive(false);
            Destroy(gameObject);
            GameOver();


        }

    }



}
