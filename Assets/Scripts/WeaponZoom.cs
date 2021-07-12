using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = 0.5f;
    [SerializeField] RigidbodyFirstPersonController fpsController;

    bool zoomedInToggle = false;

    void OnDisable()
    {
        zoomedInToggle = false;
        ZoomHandler(zoomedOutFOV, zoomOutSensitivity);
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (!zoomedInToggle)
            {
                zoomedInToggle = true;
                ZoomHandler(zoomedInFOV, zoomInSensitivity);
            }
            else
            {
                zoomedInToggle = false;
                ZoomHandler(zoomedOutFOV, zoomOutSensitivity);
            }
        }
    }

    void ZoomHandler(float zoomLevel, float sensitivity)
    {
        fpsCamera.fieldOfView = zoomLevel;
        fpsController.mouseLook.XSensitivity = sensitivity;
        fpsController.mouseLook.YSensitivity = sensitivity;
    }
}
