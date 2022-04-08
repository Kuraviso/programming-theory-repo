using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    protected float enemySpeed;
    protected float enemyFireRate;
    protected float bottomBound = -60f;
    protected Vector3 enemyMisileOffset;


    // method to rotate down the enemy prefabs so i dont have to do it manually xD
    public void rotateDown()
    {
        transform.Rotate(Vector3.up * 180);

    }

    // move down the enemies.
    public void MoveDown()
    {

        transform.Translate(Vector3.forward * enemySpeed * Time.deltaTime);

    }

    // make the enmies shoot misiles from the objectpooler (just like the player, it uses the same pool)
    public void EnemyShootMisiles()
    {


        GameObject misile = ObjectPooler.SharedInstance.GetPooledObject();
        if (misile != null)
        {
            misile.transform.position = transform.position - enemyMisileOffset;
            misile.transform.rotation = transform.rotation;
            misile.SetActive(true);
        }

    }



    public virtual void DestroyEnemy()
    {

        Destroy(gameObject);
    }


}




