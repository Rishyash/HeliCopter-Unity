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
    [SerializeField]
    protected Rigidbody rb;

    #endregion

    #region BuildInregion
    public virtual void Start()
    {
       
        weight = WeightInKG;
        ///Debug.Log("hoi");
        rb = GetComponent<Rigidbody>();
        if(rb)
        {
            rb.mass = weight;
            
        }
    }


    public virtual void Update()
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
