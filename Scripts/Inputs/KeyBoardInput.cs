using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardInput : Input_Base
{
    #region Variable
    [Header("Heli Keyboard Input Properties")]
    
    #endregion
    #region Properties
    private float throttleInput = 0;
    private float collectiveInput = 0;
    private Vector2 cyclicInput = new Vector2(0,0);
    private float padalInput = 0f;
    public float ThrottleInput
    {
        get { return throttleInput; }
    }
    public float CollectiveInput
    {
        get { return collectiveInput; }
    }
    public Vector2 CyclicInput
    {
        get { return cyclicInput; }
    }

    public float PadalInput
    {
        get { return padalInput; }
    }

    protected float stickyThrottle;
    public float StickyThrottle
    {
        get { return stickyThrottle; }
    }

    #endregion


    #region BuildInregion
    void Start()
    {

    }

    #endregion

    #region CustomMethod

    protected override void HandleInput()
    {
        base.HandleInput();
        HandlePadalInput();
        HandleThrottleInput();
        HandleCyclicInput();
        HandleCollectiveInput();

        HandleStickyThrottle();
        
        
    }

    void HandleThrottleInput()
    {
        throttleInput = Input.GetAxis("Throttle");
    }
     void HandlePadalInput()
    {
        padalInput = Input.GetAxis("Padal");
    }
    void HandleCollectiveInput()
    {
        collectiveInput = Input.GetAxis("Collective");
    }
    void HandleCyclicInput()
    {
        cyclicInput.y = Vertical;
        cyclicInput.x = Horizontal;
    }

    protected void HandleStickyThrottle()
    {
        stickyThrottle += ThrottleInput * Time.deltaTime;
        stickyThrottle = Mathf.Clamp01(stickyThrottle);
        //Debug.Log(stickyThrottle);
    }
    #endregion
}
