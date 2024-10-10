using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    //Classe non commentata perchè non utilizzata

    #region =02=== membri & proprietà ==============
    bool flag = false;
    #endregion

    #region =05=== metodi public =================
    void Update()
    {
        if (flag)
        {
            transform.Rotate(new Vector3(0f, 0.5f, 0));
        }
    }

    public void colorAdd()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    public void colorRemove()
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
    public void destroyObject()
    {
        Destroy(gameObject);
    }
    public void randomColor()
    {
        GetComponent<MeshRenderer>().material.color = UnityEngine.Random.ColorHSV();
    }
    public void rotateCube()
    {
        flag = true;
    }
    public void stopRotate()
    {
        flag = false;
    }
    #endregion
}
