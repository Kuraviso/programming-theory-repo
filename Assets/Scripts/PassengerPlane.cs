using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassengerPlane : EnemyController
{
    private float passengerPlaneSpeed;
    private float randomRotation;
    private void Start()
    // make the passenger plane look in the right direction
    {
        passengerPlaneSpeed = Random.Range(40, 70);
        enemySpeed = passengerPlaneSpeed;
        //rotateDown();
        randomRotation = Random.Range(160, 200);
        transform.Rotate(Vector3.up * randomRotation);
    }

    private void Update()
    {
        // method from the parent class to move down the passenger plane.

        MoveDown();
        DestroyEnemy();

    }
    //POLYMORPHISM
    public override void DestroyEnemy()
    {
        if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);

        }
    }

}
