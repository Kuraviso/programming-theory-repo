using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private float spawnRate;
    public bool isGameActive;
    private Vector3 spawnPos;
    private bool spawnBool;
    private Vector3 spawnPosBoolRight;
    private Vector3 spawnPosBoolLeft;
    [SerializeField] private List<GameObject> enemies;
    private GameObject player;



    void Start()
    {

        isGameActive = true;
        player = GameObject.Find("Fighter");
        // set the loop value to true and start the coroutine.
        StartCoroutine(SpawnTarget());


    }

    private void Update()
    {


    }

    // enemy spawner loop with condition.
    IEnumerator SpawnTarget()
    {


        while (isGameActive && player != null)
        {
            spawnRate = Random.Range(0.5f, 2);
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, enemies.Count);
            spawnPosBoolRight = new Vector3(-140f, 0, Random.Range(-25, 85));
            spawnPosBoolLeft = new Vector3(115f, 0, Random.Range(-25, 85));
            spawnPos = new Vector3(Random.Range(-100f, 80), 0, 115);

            if (index != 2)
            {

                Instantiate(enemies[index], spawnPos, transform.rotation);
            }
            else
            {
                spawnBool = Random.value > 0.5;
                if (spawnBool == true)
                {
                    var position = spawnPosBoolRight;
                    //var rotation = transform.rotation.y * 90;
                    Quaternion rotation = Quaternion.Euler(0, 90, 0);
                    Instantiate(enemies[index], position, rotation);
                }
                else
                {

                    var position = spawnPosBoolLeft;
                    //transform.Rotate(Vector3.up * -90);
                    Quaternion rotation = Quaternion.Euler(0, -90, 0);

                    Instantiate(enemies[index], position, rotation);
                }

            }

        }

    }



}
