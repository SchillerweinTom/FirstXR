using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ColorController : MonoBehaviour
{
   
    #region =02=== membri & proprietà ==============
    [SerializeField]
    GameObject r;
    [SerializeField]
    GameObject g;
    [SerializeField]
    GameObject b;
    [SerializeField]
    GameObject colorImage;

    [SerializeField]
    GameObject debugText;


    private UnityEngine.Color color;

    public UnityEngine.Color Color
    {
        get { return color; }
        set { color = value; }
    }
    #endregion

    #region =03=== costruttori =========================
    #endregion

    #region =04=== metodi private e aiuto ==================
    #endregion

    #region =05=== metodi public =================
    //Aggiorna il colore nell'UI in base agli slider
    public void UpdateColor()
    {
        int red = (int)Math.Floor(r.GetComponent<Slider>().value);
        int green = (int)Math.Floor(g.GetComponent<Slider>().value);
        int blue = (int)Math.Floor(b.GetComponent<Slider>().value);

        color = new UnityEngine.Color(red, green, blue, 1);

        debugText.GetComponent<TextMeshProUGUI>().text = color.ToString();

        colorImage.GetComponent<Image>().color = color;
    }
    #endregion
}
