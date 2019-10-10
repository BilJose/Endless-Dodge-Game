using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    bool gameOver = false;
    int score = 0;

    public GameObject gameOverPanel;
    public Text scoreText; 
    void Awake()
    {
        if(gm == null)
        {
            gm = this;
        }
    }
    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    public void IncrementScore()
    {
        if(!gameOver)
        {
            score++;
            print(score);

            scoreText.text = score.ToString();
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void GameOVer()
    {
        gameOver = true;
        GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>().StopSpawning();

        gameOverPanel.SetActive(true);
    }
}
