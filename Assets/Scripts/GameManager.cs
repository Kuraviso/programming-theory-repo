using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    private PlayerController player;

    [SerializeField] private TextMeshProUGUI playerNameTag;
    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI HighScoreText;
    [SerializeField] private TextMeshProUGUI restartText;
    [SerializeField] private TextMeshProUGUI newHighScoreText;
    [SerializeField] private Button menuButton;





    private void Start()
    {
        player = GameObject.Find("Fighter").GetComponent<PlayerController>();
        playerNameTag.text = MenuManager.instance.playerTag;
        HighScoreText.text = $"HighScore: {MenuManager.instance.playerName} {MenuManager.instance.playerHighScore}";
    }


    private void Update()
    {

        GameRestart();
        scoreText.text = $"Score: {player.score}";

    }

    private void GameRestart()
    {


        if (player.isAlive == false)
        {
            menuButton.gameObject.SetActive(true);
            gameOverText.gameObject.SetActive(true);
            restartText.gameObject.SetActive(true);

            if (player.score > MenuManager.instance.playerHighScore)
            {
                newHighScoreText.gameObject.SetActive(true);
                MenuManager.instance.playerHighScore = player.score;
                MenuManager.instance.playerName = playerNameTag.text;
                MenuManager.instance.SaveScore();

            }


            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(1);

            }


        }


    }

    public void BackToMenu()
    {

        SceneManager.LoadScene(0);

    }

}



