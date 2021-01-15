using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliEngine : MonoBehaviour
{
    #region Variable
    public float MaxRPM = 2000f;
    public float MaxhorsePower = 100f;
    public float PowerDelay = 2f;
    public AnimationCurve powerCurve = new AnimationCurve(new Keyframe(0,0),new Keyframe(1,1));
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
        //calculate HP
        float wantedHp = powerCurve.Evaluate( throttleinput) * MaxhorsePower; /// we get (- maxhp to maxhp);
        //Debug.Log(wantedHp);
        currHP = Mathf.Lerp(currHP, wantedHp, Time.deltaTime * PowerDelay);
        //Debug.Log(currHP);
        //calculate RPM
        float wantedRpm = throttleinput * MaxRPM;
        currRPM = Mathf.Lerp(currRPM, wantedRpm, Time.deltaTime * PowerDelay);
        
        //Debug.Log(currRPM);
    }
    #endregion
}
