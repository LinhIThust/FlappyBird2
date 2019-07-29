using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private int score,bigScore;
    public bool gameOver = false;
    [SerializeField]
    private Text textScore, endScore, highScore;
    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject birdObject;

    // Start is called before the first frame update
  
    void Start()
    {
        bigScore = PlayerPrefs.GetInt("high_score");
        highScore.text = "HIGH SCORE :"+bigScore;
        SetUpGame();
    }

    public void SetUpGame()
    {
        Time.timeScale = 1;
        score = 0;
        textScore.text = "SCORE:"+score;
        menuPanel.SetActive(false);
        if(gameOver)
            SceneManager.LoadScene("SampleScene");
    }

    public void UpdateScore()
    {
        if (gameOver) return;
        score++;
        textScore.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOver = true;
        menuPanel.SetActive(true);
        Time.timeScale = 0;
        UpdateHighScore();
        textScore.text = "";
        endScore.text = "Score:" + score;
        Debug.Log("EndGame");

    }
    public void UpdateHighScore()
    {
        if (score> bigScore)
        {
            bigScore = score;
            PlayerPrefs.SetInt("high_score", bigScore);
            highScore.text = "HIGH SCORE:" + bigScore;
        }
    }
    
}
