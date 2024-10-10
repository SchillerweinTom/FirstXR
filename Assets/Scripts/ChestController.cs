using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour, IOpenable
{
    
    #region =02=== membri & proprietà ==============
    [SerializeField]
    GameObject chest;
    public bool IsOpen
    {
        get { return IsOpen; }
        set { IsOpen = value; }
    }
    #endregion

    #region =05=== metodi public =================
    /// <summary>
    /// Chiude a "chiave" il lucchetto
    /// </summary>
    public void Close()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        chest.GetComponent<Rigidbody>().freezeRotation = true;
        IsOpen = false;
    }
    /// <summary>
    /// Apre il lucchetto
    /// </summary>
    public void Open()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
        chest.GetComponent<Rigidbody>().freezeRotation = false;
        IsOpen = true;
    }

    /// <summary>
    /// Quando parte il gioco la chest è chiusa
    /// </summary>
    void Start()
    {
        Close();
    }
    #endregion
}
