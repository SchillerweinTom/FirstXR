using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectibleController : MonoBehaviour
{
    
    #region =02=== membri & proprietà ====================
    [SerializeField]
    ScoreManager scoreManager;
    #endregion

    #region =05=== metodi public =================
    // Distrugge l'oggetto selezionato e aumenta il punteggio.
    public void destroyObject()
    {
        scoreManager.addScore();
        Destroy(gameObject);
    }
    #endregion
}
