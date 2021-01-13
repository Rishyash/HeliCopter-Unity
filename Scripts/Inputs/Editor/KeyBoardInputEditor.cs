using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(KeyBoardInput))]
public class KeyBoardInputEditor : Editor
{
    #region Variable
    private KeyBoardInput input;
    #endregion

    #region BuildInregion
   
    private void OnEnable()
    {
        input = (KeyBoardInput)target; 
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        DrawDebugUi();
        Repaint();
    }
    #endregion

    #region CustomMethod
    void DrawDebugUi()
    {
        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        EditorGUILayout.Space(10);
        EditorGUILayout.LabelField("Throttle - " + input.ThrottleInput.ToString("0.00"), EditorStyles.boldLabel) ;
        EditorGUILayout.LabelField("Collective - " + input.CollectiveInput.ToString("0.00"), EditorStyles.boldLabel);
        EditorGUILayout.LabelField("Cyclic - " + input.CyclicInput.ToString("0.00"), EditorStyles.boldLabel);
        EditorGUILayout.LabelField("Padal - " + input.PadalInput.ToString("0.00"), EditorStyles.boldLabel);
        EditorGUILayout.Space(10);
        EditorGUILayout.EndVertical();
    }
    #endregion
}
