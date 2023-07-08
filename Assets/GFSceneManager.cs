using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class GFSceneManager : MonoBehaviour
{
    [SerializeField] private Camera _cam;
   // private int oldMask;
   /*private void Awake()
   {
       _cam = FindObjectOfType<Camera>();
       oldMask = _cam.cullingMask;
   }*/

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ho colliso con: " + other);
        if (other.tag == "Trigger")
        {
            CameraExtensions.LayerCullingHide(_cam, "Room" );
            CameraExtensions.LayerCullingHide(_cam, "NeonLayer");
            CameraExtensions.LayerCullingHide(_cam,"Default");
            CameraExtensions.LayerCullingShow(_cam, "Grande Fratello");
        }
        
    }
}

