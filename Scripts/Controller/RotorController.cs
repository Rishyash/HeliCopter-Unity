using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RotorController : MonoBehaviour
{
    #region Variable
    public List<RotorInterface> rotors = new List<RotorInterface>();
    public float maxdps;
    #endregion

    #region BuildInregion
    void Start()
    {
        rotors = GetComponentsInChildren<RotorInterface>().ToList<RotorInterface>();
    }


    void Update()
    {
        
    }
    #endregion

    #region CustomMethod
    public void UpdateRotors(KeyBoardInput input, float currentRPM)
    {
        //Debug.Log("ROTOR");
        //Debug.Log(currentRPM);
        //Dergree Per Sec
         float dps = (  (currentRPM * 360f) / 60f) ;
           dps = Mathf.Clamp(dps, 0, maxdps);
        //Update Rotor
        foreach(var rotor in rotors)
        {
            rotor.UpdateRotor(dps,input);
        }
    }
    #endregion
}
