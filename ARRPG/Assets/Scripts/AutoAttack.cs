using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAttack : MonoBehaviour {

    public GameObject particle;
    private float autoAttackCooldown;

    public void AutoAttacking()
    {
        if (autoAttackCooldown <= 0)
        {
            Instantiate(particle, Camera.main.transform.position, transform.rotation);
            autoAttackCooldown = 1.5f;
        }
    }

    void Update()
    {
        if (autoAttackCooldown > 0)
        {
            autoAttackCooldown -= Time.deltaTime;
        }
    }
}
