using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(KeyBoardInput))]
public class HeliController : RigidBodyBase
{
    #region Variable
    [Header("Helicopter  Properties")]
    public List<HeliEngine> engines = new List<HeliEngine>();

    [Header("Rotor Controller")]
    public RotorController rotorCtrl;
    protected KeyBoardInput input;
    private HeliCharacterstic characterstic;
    #endregion

    #region BuildInregion
    public override void Start()
    {
        base.Start();
        input = GetComponent<KeyBoardInput>();
        characterstic = GetComponent<HeliCharacterstic>();
    }


    public override void FixedUpdate()
    {
        base.FixedUpdate();
    }
    #endregion

    #region CustomMethod
    protected override void HandlePhycics()
    {
        if (input)
        {
            HandleCharacterstic();
            HandleEngine();
            HandleRotor();
           
        }
       
    }

    protected virtual void HandleEngine()
    {
        foreach(HeliEngine engine in engines )
        {
            engine.UpdateEngine(input.StickyThrottle);
        }
    }

    protected virtual void HandleRotor()
    {
        if(rotorCtrl)
        {
            rotorCtrl.UpdateRotors(input, engines[0].CurrRPM);
        }
    }

    protected virtual void HandleCharacterstic()
    {
        if(characterstic)
        {
            characterstic.UpdateCharacterstic(rb,input);
        }
    }
    #endregion
}
