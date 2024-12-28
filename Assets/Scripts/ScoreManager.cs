using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text ScoreText;
    public Text HighestScoreText;

    private void Awake()
    {
        instance = this;
    }

    int Score = 0;
    int HighestScore = 0;

    void Start()
    {
        HighestScore = PlayerPrefs.GetInt("highscore", 0);
        ScoreText.text = "SCORE: " + Score.ToString();
        HighestScoreText.text = "HIGHEST SCORE: " + HighestScore.ToString();
    }

    public void AddScore()
    {
        Score += 1;
        ScoreText.text = "SCORE: " + Score.ToString();
        if (HighestScore < Score)
            PlayerPrefs.SetInt("highscore", Score);
    }
}
