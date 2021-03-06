using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //ENCAPSULATION2
    protected int playerLives;
    protected float playerSpeed;
    protected float playerFireRate;
    protected Vector3 playerMisileOffset;
    private float topBound = 75;
    private float bottomBound = -27.5f;
    private float leftBound = -120;
    private float rightBound = 92;
    public ParticleSystem explosionParticle;

    public bool isAlive;
    public int score;

    private Vector3 fighterOffsetPos = new Vector3(5, 0.5f, 20);
    private Vector3 fighterOffsetNeg = new Vector3(-5, 0.5f, 20);




    private float horizontalInput;
    private float verticalInput;

    private void Start()
    {

    }


    //ABSTRACTION
    public void CharacterMovement()
    {

        horizontalInput = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        verticalInput = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        transform.Translate(new Vector3(horizontalInput, 0, verticalInput));

        //max z position
        if (transform.position.z > topBound)
        {
            transform.position = new Vector3(transform.position.x, 0, topBound);

        }

        // min z position
        if (transform.position.z < bottomBound)
        {
            transform.position = new Vector3(transform.position.x, 0, bottomBound);

        }

        // max left bound
        if (transform.position.x < leftBound)
        {
            transform.position = new Vector3(leftBound, 0, transform.position.z);

        }

        // max right bound
        if (transform.position.x > rightBound)
        {
            transform.position = new Vector3(rightBound, 0, transform.position.z);
        }


    }

    public void ShootMisiles()
    {
        GameObject misile = ObjectPooler.SharedInstance.GetPooledObject();
        if (misile != null)
        {
            misile.transform.position = transform.position + fighterOffsetPos;
            misile.transform.rotation = transform.rotation;
            misile.SetActive(true);
        }

        GameObject misile2 = ObjectPooler.SharedInstance.GetPooledObject();
        if (misile != null)
        {
            misile2.transform.position = transform.position + fighterOffsetNeg;
            misile2.transform.rotation = transform.rotation;
            misile2.SetActive(true);
        }


    }



    public void GameOver()
    {
        isAlive = false;


    }

    public void AddScore(int points)
    {

        score += points;

    }


}
