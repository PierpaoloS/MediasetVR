using System;
using System.Collections;
using System.Collections.Generic;
//using TMPro.EditorUtilities;
using UnityEngine;

public class GFSceneManager : MonoBehaviour
{
    [SerializeField] private Camera _cam;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ho colliso con: " + other);
        if (other.tag == "MainCamera")
        {
            CameraExtensions.LayerCullingHide(_cam, "Room" );
            CameraExtensions.LayerCullingHide(_cam, "NeonLayer");
            CameraExtensions.LayerCullingHide(_cam,"Default");
            CameraExtensions.LayerCullingHide(_cam,"TVLights");
            CameraExtensions.LayerCullingHide(_cam,"Palinsesto");
            CameraExtensions.LayerCullingShow(_cam, "Grande Fratello");
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Sto uscendo dalla collisione " + other);
        if (other.tag == "MainCamera")
        {
            CameraExtensions.LayerCullingShow(_cam, "Room" );
            CameraExtensions.LayerCullingShow(_cam, "NeonLayer");
            CameraExtensions.LayerCullingShow(_cam,"Default");
            CameraExtensions.LayerCullingShow(_cam,"TVLights");
            CameraExtensions.LayerCullingShow(_cam,"Palinsesto");
            CameraExtensions.LayerCullingHide(_cam, "Grande Fratello");
        }
        
    }
}

