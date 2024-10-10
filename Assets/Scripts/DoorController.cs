using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour, IOpenable
{
    

    

    #region =02=== membri & proprietà ==============
    [SerializeField]
    GameObject door;

    public bool IsOpen
    {
        get { return IsOpen; }
        set { IsOpen = value; }
    }
    #endregion

    #region =05=== metodi public =================
    //Chiude la porta a chiave
    void Start()
    {
        Close();
    }

    //Controlla se viene aperta la porta tramite la carta magnetica
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("KeyCard"))
        {
            Open();
        }
    }

    //Metodo per sbloccare la porta e impostare il colore verde sullo scanner
    public void Open()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
        door.GetComponent<Rigidbody>().freezeRotation = false;
        IsOpen = true;
    }

    //Metodo per bloccare la porta e impostare il colore rosso sullo scanner
    public void Close()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        door.GetComponent<Rigidbody>().freezeRotation = true;
        IsOpen = false;
    }
    #endregion
}
