using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private float spawnRate;
    public bool isGameActive;
    private Vector3 spawnPos;
    [SerializeField] private List<GameObject> enemies;



    void Start()
    {
        // set the loop value to true and start the coroutine.
        isGameActive = true;
        StartCoroutine(SpawnTarget());


    }

    // enemy spawner loop with condition.
    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            spawnRate = Random.Range(2, 3);
            yield return new WaitForSeconds(spawnRate);

            int index = Random.Range(0, enemies.Count);
            spawnPos = new Vector3(Random.Range(-160f, 130), 0, 130);
            Instantiate(enemies[index], spawnPos, transform.rotation);

        }

    }

    // if the player is dead stop spawning enemies.
    public void GameOver()
    {
        isGameActive = false;

    }

}
