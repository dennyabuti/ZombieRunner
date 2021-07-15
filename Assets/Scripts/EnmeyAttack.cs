using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnmeyAttack : MonoBehaviour
{
    [SerializeField] float damage = 40f;

    PlayerHealth playerHealth;
    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    public void AttackHitEvent()
    {
        if (playerHealth == null) return;

        playerHealth.TakeDamage(damage);
        playerHealth.GetComponent<DisplayDamage>().ShowDamageImpact();
    }

    public void OnDamageTaken()
    {
        // TODO: Be more aggressive 
    }
}
