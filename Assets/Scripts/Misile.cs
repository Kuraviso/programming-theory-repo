using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misile : MonoBehaviour
{

    private float misileSpeed = 200;
    private float misileRangeP = 125;
    private float misileRangeN = -60;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // make the misile move forward.
        transform.Translate(Vector3.forward * misileSpeed * Time.deltaTime);

        DestroyMisile();
    }

    // if the misile goes above or below the max range destroy it 
    private void DestroyMisile()
    {
        if (gameObject.transform.position.z > misileRangeP || gameObject.transform.position.z < misileRangeN)
        {

            gameObject.SetActive(false);

        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Fighter"))
        {
            Destroy(collision.gameObject);
            gameObject.SetActive(false);

        }
    }

}
