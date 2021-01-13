using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class HelicopterSetupWindow : EditorWindow
{
    #region Variable
    private string Helicoptername = null;
    private Object model;
    #endregion

    #region buildinRegion
    public static void LaunchSetupWindow()
    {
        HelicopterSetupWindow.GetWindow(typeof(HelicopterSetupWindow), true, "HelicopterSetup").Show();
    }

    private void OnGUI()
    {
        Helicoptername = EditorGUILayout.TextField("AirPlane Name", Helicoptername);
        model = EditorGUILayout.ObjectField("Prefab",model,typeof(Object),true); 
        if(GUILayout.Button("Create Helicopter"))
        {
            SetupTools.CreateDefaultPlane(Helicoptername,model);
            HelicopterSetupWindow.GetWindow(typeof(HelicopterSetupWindow), true, "HelicopterSetup").Close();
        }
       
        }
    }
    #endregion

