using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightSystem : MonoBehaviour
{
    [SerializeField] float lightDecay = .1f;
    [SerializeField] float angleDecay = .5f;
    [SerializeField] float minAngle = 40f;

    Light light;

    void Start()
    {
        light = GetComponent<Light>();
    }

    void Update()
    {
        DecreaseLightAngle();
        DecreaseLightIntensity();
    }

    public void RestoreLightAngle(float restoreAngle)
    {
        light.spotAngle = restoreAngle;
    }

    public void RestoreLightIntensity(float amount)
    {
        light.intensity += amount;
    }
    void DecreaseLightAngle()
    {
        if (light.spotAngle <= minAngle) return;

        light.spotAngle -= angleDecay * Time.deltaTime;
    }

    void DecreaseLightIntensity()
    {
        light.intensity -= lightDecay * Time.deltaTime;
        
    }


}
