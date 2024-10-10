using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIController : MonoBehaviour
{

    #region =02=== membri & proprietà ==============
    [SerializeField]
    GameObject UI;
    #endregion

    #region =05=== metodi public =================
    //Quando il gioco parte la UI non è visibile
    void Start()
    {
        UI.gameObject.SetActive(false);
    }

    //Quando il giocatore preme sulla sfere, l'UI viene aperta.
    public void clickedOnSphere()
    {
        UI.gameObject.SetActive(true);
    }
    #endregion
}
