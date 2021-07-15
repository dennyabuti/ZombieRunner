using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int restoreAmount = 1;
    [SerializeField] float restoreAngle = 90f;



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FlashLightSystem flashLightSystem = other.gameObject.GetComponentInChildren<FlashLightSystem>();
            flashLightSystem.RestoreLightAngle(restoreAngle);
            flashLightSystem.RestoreLightIntensity(restoreAmount);
            Destroy(gameObject);
        }
    }
}
