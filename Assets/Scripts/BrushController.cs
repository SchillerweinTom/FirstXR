using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushController : MonoBehaviour
{

    #region =02=== membri & proprietà ==============
    ColorController colorController;
    [SerializeField]
    GameObject paint;
    #endregion

    #region =04=== metodi private e aiuto ===============
    /// <summary>
    /// Colora gli oggetti che vengono toccati
    /// </summary>
    /// <param name="collision">Il collisore.</param>
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<MeshRenderer>().material.color = colorController.Color;
    }
    #endregion

    #region =05=== metodi public ==============
    //Colora il pennello con il colore selezionato dal pannello
    void Start()
    {
        paint.GetComponent<MeshRenderer>().material.color = colorController.Color;
    }
    #endregion
}
