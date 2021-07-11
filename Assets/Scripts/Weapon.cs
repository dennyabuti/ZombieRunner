using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera fPCamera;
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 30f;
    [SerializeField] ParticleSystem muzzleFlash;
    [SerializeField] GameObject hitEffect;
    [SerializeField] Ammo ammoSlot;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammoSlot.AmmoAmount > 0)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        PlayMuzzleFlash();
        ProcessRayCast();
        ammoSlot.ReduceCurrentAmmo();
    }

    void ProcessRayCast()
    {
        RaycastHit hit;

        if (Physics.Raycast(fPCamera.transform.position, fPCamera.transform.forward, out hit, range))
        {
            CreateHitImpact(hit);

            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();

            if (target == null) return;

            target.TakeDamage(damage);
        }
    }

    void PlayMuzzleFlash()
    {
        muzzleFlash.Play();
    }

    void CreateHitImpact(RaycastHit hit)
    {
        GameObject impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));

        Destroy(impact, 0.1f);
    }
}
