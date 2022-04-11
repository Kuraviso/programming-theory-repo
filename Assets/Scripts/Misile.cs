using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misile : MonoBehaviour
{

    private float misileSpeed = 200;
    private float misileRangeP = 125;
    private float misileRangeN = -60;
    [SerializeField] GameObject playerGo;
    private PlayerController playerScript;
    [SerializeField] ParticleSystem explosion;



    private void Start()
    {
        if (playerGo != null)
        {
            playerScript = GameObject.Find("Fighter").GetComponent<PlayerController>();
        }
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
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Instantiate(explosion, collision.transform.position, Quaternion.identity);
            playerScript.score += 50;
            Destroy(collision.gameObject);
            gameObject.SetActive(false);

        }
        else if (collision.gameObject.CompareTag("Ally"))
        {
            Instantiate(explosion, collision.transform.position, Quaternion.identity);
            playerScript.score -= 100;
            Destroy(collision.gameObject);
            gameObject.SetActive(false);


        }
    }

}
