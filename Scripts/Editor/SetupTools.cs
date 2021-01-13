 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; 

public static class SetupTools 
{   
    public static void CreateDefaultPlane(string Aname,Object DefaultPlane)
    {
        //Create Plane
        GameObject rootGO = new GameObject(Aname, typeof(HeliController));
        GameObject Cog = new GameObject("COG");
        Cog.transform.SetParent(rootGO.transform, false);

        //SetupComponent
        //KeyBoardInput inputs = rootGO.GetComponent<KeyBoardInput>();
        HeliController controller = rootGO.GetComponent<HeliController>();
        //AirplaneCharacteristics characteristics = rootGO.GetComponent<AirplaneCharacteristics>();

        if(controller)
        {
            
            
            controller.Cog = Cog.transform;

            //createSurfaces
            GameObject GraphicsGRP = new GameObject("Graphics");
            GameObject CollisionGRP = new GameObject("CollisionGRP");
            GameObject ControlSurfaceGrp = new GameObject("ControlSurfaceGrp");
            GraphicsGRP.transform.SetParent(rootGO.transform, false);
            CollisionGRP.transform.SetParent(rootGO.transform, false);
            ControlSurfaceGrp.transform.SetParent(rootGO.transform, false);

            //CreateEngine
            //GameObject EngineGO = new GameObject("Engine",typeof(AirplaneEngine));
            //AirplaneEngine engine = EngineGO.GetComponent<AirplaneEngine>();
            //controller.engines.Add(engine);
           // EngineGO.transform.SetParent  (rootGO.transform, false);

            //CreatePlaneBody

            

            if(DefaultPlane)
            {
                GameObject.Instantiate(DefaultPlane,GraphicsGRP.transform);
            }
            else
            {
                DefaultPlane = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Intro_Heli_Physics/Prefabs/Helicopters/R22_Helicopter_Geo.prefab", typeof(GameObject));
                GameObject.Instantiate(DefaultPlane, GraphicsGRP.transform);
            }
            

        }
        Selection.activeObject = rootGO;


        /*GameObject CurrentSelected = Selection.activeGameObject;
        if (CurrentSelected)
        {
            AirplaneController curController = CurrentSelected.AddComponent<AirplaneController>();
            GameObject curCOG = new GameObject("COG");
            curCOG.transform.SetParent(CurrentSelected.transform);
            curController.centerofgravity = curCOG.transform;
        }*/
    }
    
}
