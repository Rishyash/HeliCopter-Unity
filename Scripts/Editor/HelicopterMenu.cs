using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public static class HelicopterMenu
{
    [MenuItem("Helicopter Tools/Create New Helicopter")]
    public static void CreatenewHelicopter()
    {
        //SetupTools.CreateDefaultPlane("Airplane");
        HelicopterSetupWindow.LaunchSetupWindow();
    }
}
