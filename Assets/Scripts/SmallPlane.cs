using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallPlane : EnemyController
{

    private float planeSpeed = 100f;
    private float horizontalBounds = 160;

    // Start is called before the first frame update
    void Start()
    {
        enemySpeed = planeSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        MoveDown();
        DestroyEnemy();
    }

    public override void DestroyEnemy()
    {
        if ((transform.position.x > horizontalBounds) || (transform.position.x < -horizontalBounds))
        {

            Destroy(gameObject);
        }
    }
}
