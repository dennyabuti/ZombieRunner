using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
 [SerializeField] int currentWeapon = 0;

 void Start()
 {
     SetActiveWeapon();
 }

 void Update()
 {
     int prevWeapon = currentWeapon;

     ProcessKeyInput();
     ProcessScrollWheel();

     if (prevWeapon != currentWeapon)
     {
         SetActiveWeapon();
     }
 }

   void ProcessScrollWheel()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if(currentWeapon >= transform.childCount -1)
            {
                currentWeapon = 0;
            }
            else
            {
                currentWeapon++;
            }
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if(currentWeapon <= 0)
            {
                currentWeapon = transform.childCount - 1;
            }
            else
            {
                currentWeapon--;
            }
        }
    }

    void ProcessKeyInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeapon = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeapon = 2;
        }
    }

    void SetActiveWeapon()
 {
     int index = 0;

     foreach(Transform weapon in transform)
     {
         if (index == currentWeapon)
         {
             weapon.gameObject.SetActive(true);
         }
         else
         {
             weapon.gameObject.SetActive(false);
         }

         index++;
     }

 }
}
