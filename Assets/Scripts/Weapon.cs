using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera fPCamera;
    [SerializeField] float range = 100f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        Physics.Raycast(fPCamera.transform.position, fPCamera.transform.forward, out hit, range);

        Debug.Log($"Shot {hit.transform.name}");
    }
}
