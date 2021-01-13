using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliEngine : MonoBehaviour
{
    #region Variable
    public float MaxRPM = 2000f;
    public float horsePower = 100f;
    public float PowerDelay = 2f;
    #endregion
    #region Properties
    private float currHP;
    public float CurrHP
    {
        get { return currHP; }
    }

    private float currRPM;
    public float CurrRPM
    {
        get { return currRPM; }
    }
    #endregion
    #region BuildInregion
    void Start()
    {

    }
    #endregion

    #region CustomMethod
    public void UpdateEngine(float throttleinput)
    {

    }
    #endregion
}
