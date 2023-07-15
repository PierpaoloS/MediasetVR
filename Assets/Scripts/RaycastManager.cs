using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RaycastManager : MonoBehaviour
{
    [SerializeField] private XRRayInteractor _leftRay;
    [SerializeField] private XRRayInteractor _rightRay;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PalinsestoCircle")
        _leftRay.enabled = true;
        _rightRay.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "PalinsestoCircle")
        _leftRay.enabled = false;
        _rightRay.enabled = false;
    }
}
