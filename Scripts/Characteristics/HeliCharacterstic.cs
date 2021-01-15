using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliCharacterstic : MonoBehaviour
{
    #region Variable
    [Header("Lift Properties")]
    public float maxLiftForce = 100f;
    public float liftPowerMultiplyier = 3f;
    public MainRotor mainRotor;

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
    public virtual void UpdateCharacterstic(Rigidbody rb,KeyBoardInput input)
    {
        HandleLift(rb,input);
        HandleCollective(rb, input);
        HandlePadal(rb, input);
    }
    protected virtual void HandleLift(Rigidbody rb, KeyBoardInput input)
    {
        Vector3 liftForce = transform.up * (Physics.gravity.magnitude + maxLiftForce) * rb.mass;
        float normalizedRPM = mainRotor.CurrentRPM / 500f;
        rb.AddForce(liftForce* Mathf.Pow(normalizedRPM,2f) * Mathf.Pow(input.CollectiveInput,liftPowerMultiplyier));
       // Debug.Log(liftForce);
    }

    protected virtual void HandleCollective(Rigidbody rb, KeyBoardInput input)
    {

    }
    protected virtual void HandlePadal(Rigidbody rb, KeyBoardInput input)
    {

    }
    #endregion
}
