using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoadScores : MonoBehaviour
{
        
    #region =02=== membri & proprietà ==============
    [SerializeField]
    GameObject text1;
    [SerializeField]
    GameObject text2;
    [SerializeField]
    GameObject text3;
    #endregion

    #region =05=== metodi public =================
    //Quando la scena parte carica gli score.
    void Start()
    {
        loadScores();
    }
    //Carica gli score nella UI degli Highscore
    public void loadScores()
    {
        int score1 = PlayerPrefs.GetInt("bestScore");
        int score2 = PlayerPrefs.GetInt("bestScore2");
        int score3 = PlayerPrefs.GetInt("bestScore3");

        text1.GetComponent<TextMeshProUGUI>().text = score1.ToString();
        text2.GetComponent<TextMeshProUGUI>().text = score2.ToString();
        text3.GetComponent<TextMeshProUGUI>().text = score3.ToString();
    }

    #endregion
}
