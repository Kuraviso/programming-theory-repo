using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHelicopter : EnemyController
{
    private float fireRate;
    private float helicopterSpeed = 50f;
    public bool isAlive;
    public Vector3 helicopterSpawnPos;


    // Start is called before the first frame update
    void Start()


    {

        enemyMisileOffset = new Vector3(0f, 0f, 10f);
        helicopterSpawnPos = new Vector3(Random.Range(-100f, 80), 0, 115);


        // set the enemy isAlive variable to use the loop 
        isAlive = true;
        enemySpeed = helicopterSpeed;

        // rotate down the enemy so i dont have to do it myself, and start the coroutine to shoot misiles.
        rotateDown();
        StartCoroutine("HelicopterShootMisiles");
    }

    // Update is called once per frame
    void Update()
    {
        // move the enemy down and check if its out of bounds.
        MoveDown();
        DestroyEnemy();
    }

    // coroutine to make the enemies shoot misiles on random intervals.
    IEnumerator HelicopterShootMisiles()
    {
        while (isAlive)
        {
            fireRate = Random.Range(1, 3);
            yield return new WaitForSeconds(fireRate);
            EnemyShootMisiles();

        }

    }

    // method to destroy the enemy if it is out of bounds, setting isAlive to false prevents errors.
    public override void DestroyEnemy()
    {
        if (transform.position.z < bottomBound)
        {
            isAlive = false;
            Destroy(gameObject);


        }

    }


}
