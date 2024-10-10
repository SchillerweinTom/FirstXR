using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    #region =02=== membri & proprietà ==============
    private int score;

    public int Score
    {
        get { return score; }
        set { score = value; }
    }
    #endregion

    #region =05=== metodi public =================
    //Imposta score a 0
    void Start()
    {
        score = 0;
    }

    //Aumenta lo score
    public void addScore()
    {
        score++;
    }


    //Scrive lo score e finisce il gioco
    public void endGame()
    {
        PlayerPrefs.SetInt("lastScore", score);
        setHighScore();

        SceneManager.LoadScene("Menu");
    }

    //Controlla lo score e eventualmente imposta un nuovo highscore
    public void setHighScore()
    {
        int lastScore = PlayerPrefs.GetInt("lastScore");

        int score1 = PlayerPrefs.GetInt("bestScore");
        int score2 = PlayerPrefs.GetInt("bestScore2");
        int score3 = PlayerPrefs.GetInt("bestScore3");

        if (lastScore > score1)
        {
            PlayerPrefs.SetInt("bestScore", lastScore);
            PlayerPrefs.SetInt("bestScore2", score1);
            PlayerPrefs.SetInt("bestScore3", score2);
        }
        else if (lastScore > score2)
        {
            PlayerPrefs.SetInt("bestScore2", lastScore);
            PlayerPrefs.SetInt("bestScore3", score2);
        }
        else if (lastScore > score3)
        {
            PlayerPrefs.SetInt("bestScore3", lastScore);
        }
    }
    #endregion

}
