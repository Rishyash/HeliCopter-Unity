using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotorBlurTail : MonoBehaviour, RotorInterface
{
    #region Variable
    [Header("Rotor Blur Properties")]
    public float maxDPS = 1000f;
    public List<GameObject> blades = new List<GameObject>();
    public GameObject blurRotor;
    public Material BlurMat;

    public List<Texture2D> blurBlades = new List<Texture2D>();
    #endregion

    public void UpdateRotor(float dps, KeyBoardInput input)
    {
        //float normalizedDPS = Mathf.InverseLerp(0f, maxDPS, dps);
        float normalizedDPS = Mathf.InverseLerp(0f, maxDPS, dps);
        int blurtextId = Mathf.FloorToInt(normalizedDPS * (blurBlades.Count));
        //blurtextId = Mathf.Clamp(0, 9 ,blurtextId);
        //Debug.Log(blurtextId);
        if (blurtextId > 9)
            return;

        if (blurBlades.Count > 0)
        {
            BlurMat.SetTexture("_MainTex", blurBlades[blurtextId]);
        }

        if (blurtextId > 2)
        {
            HandleMainBlade(false);
        }
        else
        {
            HandleMainBlade(true);
        }

        void HandleMainBlade(bool vis)
        {
            foreach (var blade in blades)
            {
                blade.SetActive(vis);
            }
        }





        //Debug.Log(normalizedDPS);
        // Debug.Log(normalizedDPS);
    }
}
