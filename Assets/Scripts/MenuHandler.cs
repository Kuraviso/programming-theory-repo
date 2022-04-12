using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class MenuHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField playerName;
    [SerializeField] private TextMeshProUGUI playerHighScore;

    private void Start()
    {
        setLastScore();
    }

    public void SetPlayerName()
    {

        MenuManager.instance.playerTag = playerName.text;
    }

    public void setLastScore()
    {

        playerHighScore.text = $"HighScore: { MenuManager.instance.playerName} { MenuManager.instance.playerHighScore} ";
    }

    public void StartGame()
    {
        SetPlayerName();
        SceneManager.LoadScene(1);

    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#else
        Application.Quit();

#endif
    }
}
