using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(KeyBoardInput))]
public class HeliController : RigidBodyBase
{
    #region Variable
    [Header("Helicopter  Properties")]
    public List<HeliEngine> engines = new List<HeliEngine>();
    protected KeyBoardInput input;
    #endregion

    #region BuildInregion
    void Start()
    {
        input = GetComponent<KeyBoardInput>();
    }


    void Update()
    {

    }
    #endregion

    #region CustomMethod
    protected override void HandlePhycics()
    {
        if (input)
        {
            HandleCharacterstic();
            HandleEngine();
        }  
    }

    protected virtual void HandleEngine()
    {
        foreach(HeliEngine engine in engines )
        {
            engine.UpdateEngine(input.ThrottleInput);
        }
    }

    protected virtual void HandleCharacterstic()
    {

    }
    #endregion
}
