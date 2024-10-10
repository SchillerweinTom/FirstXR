using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioController : MonoBehaviour
{
   

    

    #region =02=== membri & proprietà ==============
    [SerializeField]
    GameObject radio;
    #endregion

    #region =05=== metodi public =================
    //Fa partire la musica della radio.
    public void StartMusic()
    {
        radio.GetComponent<AudioSource>().Play();
    }

    //Ferma la musica della radio.
    public void StopMusic()
    {
        radio.GetComponent<AudioSource>().Stop();
    }
    #endregion
}
