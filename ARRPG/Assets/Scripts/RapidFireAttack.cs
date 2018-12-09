using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFireAttack : MonoBehaviour {

    [SerializeField]
    private GameObject particle;
    private float AbilityCooldown = 0f;
    private float timer;

    public void RapidFireAbility()
    {
        if (AbilityCooldown <= 0)
        {
            Instantiate(particle, Camera.main.transform.position, transform.rotation);
            AbilityCooldown = 15f;
        }
    }
	
	// Update is called once per frame
	void Update () {
		if ( AbilityCooldown >= 0)
        {
            AbilityCooldown -= Time.deltaTime;
        }

	}

}
