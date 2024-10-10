using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    #region =05=== metodi public =================
    //Avvia il gioco caricando la scena di gioco
    public void startGame()
    {
        SceneManager.LoadScene("BasicScene");
    }

    //Torna al menu principale.
    public void goMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    //Esce dall'applicazione
    public void exitGame()
    {
        Application.Quit();
    }

    //Mostra il menu degli highscore.
    public void highScore()
    {
        SceneManager.LoadScene("ScoreMenu");
    }
    #endregion
}
