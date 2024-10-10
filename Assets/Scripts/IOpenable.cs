using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IOpenable
{
    
    #region =02=== membri & proprietà ==============
    bool IsOpen { get; set; }
    #endregion

    #region =05=== metodi public =================
    void Open();
    void Close();
    #endregion
}
