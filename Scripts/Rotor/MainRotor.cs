using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainRotor : MonoBehaviour, RotorInterface
{
    #region Variable
    [Header("Main Rotor Properties")]
    public Transform LRotor;
    public Transform RRotor;
    public float MaxPitch = 35f;
    #endregion

    #region BuildInregion
    void Start()
    {

    }


    void Update()
    {

    }
    #endregion

    #region CustomMethod
    public void UpdateRotor(float dps,KeyBoardInput input)
    {
        //Debug.Log("MainRotor");
        //transform.rotation = Quaternion.Euler(0f, dps, 0f);
        transform.Rotate(Vector3.up,dps);

        // RotorPitct
        if(LRotor && RRotor)
        {
            LRotor.localRotation = Quaternion.Euler(input.CollectiveInput* MaxPitch, 0, 0);
            RRotor.localRotation = Quaternion.Euler(-input.CollectiveInput * MaxPitch, 0, 0);
        }
    }
    #endregion
}
