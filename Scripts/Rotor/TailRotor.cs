using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailRotor : MonoBehaviour , RotorInterface
{
    #region Variable
    public float RotationSpeed = 1.5f;
    [Header("Tail Rotor Properties")]
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
        //Debug.Log("TailRotor");
        transform.Rotate(Vector3.right, dps * RotationSpeed);

        if (LRotor && RRotor)
        {
            LRotor.localRotation = Quaternion.Euler(0, input.PadalInput*MaxPitch, 0);
            RRotor.localRotation = Quaternion.Euler(0, -input.PadalInput * MaxPitch, 0);
        }
    }
    #endregion
}
