using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Base : MonoBehaviour
{
    #region Variable
    [Header("Base Input Properties")]
    protected float Vertical;
    protected float Horizontal;
    #endregion

    #region BuildInregion
    void Start()
    {

    }


    void Update()
    {
        HandleInput();
    }
    #endregion

    #region CustomMethod
    protected virtual void  HandleInput()
    {
        Vertical = Input.GetAxis("Vertical");
        Horizontal = Input.GetAxis("Horizontal");
    }
    #endregion
}
