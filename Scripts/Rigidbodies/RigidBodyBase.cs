using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class RigidBodyBase : MonoBehaviour
{
    #region Variable
    [Header("Weight Properties")]
    protected float weight;
    public float WeightInKG = 10f;
    public Transform Cog;
    protected Rigidbody rb;

    #endregion

    #region BuildInregion
    void Start()
    {
        weight = WeightInKG;
        rb = GetComponent<Rigidbody>();
        if(rb)
        {
            rb.mass = weight;
        }
    }


    void Update()
    {
        if(rb)
        {
            HandlePhycics();
        }
    }
    #endregion

    #region CustomMethod
    protected virtual void HandlePhycics()
    {

    }
    #endregion
}
