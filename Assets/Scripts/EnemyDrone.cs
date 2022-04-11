using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrone : EnemyController
{
    private float droneSpeed = 20f;
    private Rigidbody enemyRb;
    private GameObject player;






    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Fighter");
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {

            transform.LookAt(player.transform.position);
            enemyRb.AddForce((player.transform.position - transform.position).normalized * droneSpeed);
        }
        else

            Destroy(gameObject);


    }




}
