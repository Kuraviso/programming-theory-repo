using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private PlayerController player;
    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI restartText;





    private void Start()
    {
        player = GameObject.Find("Fighter").GetComponent<PlayerController>();
    }


    private void Update()
    {

        GameRestart();


    }

    private void GameRestart()
    {

        if (player.isAlive == false)
        {
            gameOverText.gameObject.SetActive(true);
            restartText.gameObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);

            }


        }


    }


}



