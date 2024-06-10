using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI highscoreText;


    ScoreKeeper scoreKeeper;

    //void Awake()
    //{
    //    scoreKeeper = FindObjectOfType<ScoreKeeper>();
    //}

    //void Start()
    //{
    //    scoreText.text = "You Scored:\n" + scoreKeeper.GetScore();

    //}


    void Start()
    {
        int score = FindObjectOfType<ScoreKeeper>().GetScore();
        scoreText.text = "You Scored: \n" + score;

        int highScore = HighScoreManager.Instance.GetHighScore();
        if (score > highScore)
        {
            highScore = score;
            HighScoreManager.Instance.SetHighScore(highScore);
        }

         highscoreText.text = "High Score: \n" + highScore;
    }
}
