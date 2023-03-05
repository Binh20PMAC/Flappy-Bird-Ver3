using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private TMP_Text ScoreText;

    [SerializeField]
    private TMP_Text HighScoreText;

    public static Score instance;
    [SerializeField]
    private float score;
    [SerializeField]
    private float highScore;
    [SerializeField]
    private float temp;

    private void Awake()
    {
        instance = this;
    }


    private void Start()
    {
        highScore = PlayerPrefs.GetFloat("highscore", 0);

        HighScoreText.text = "HighScore: " + highScore.ToString();
    }

    public void ScoreUp()
    {
        temp++;
        if (temp == 80)
        {
            temp /= 80;
            score++;
        }
        ScoreText.text = score.ToString();

        if (score > highScore)
        {

            PlayerPrefs.SetFloat("highscore", score);
        }
        HighScoreText.text ="HightScore: "+ highScore.ToString();

    }
}
