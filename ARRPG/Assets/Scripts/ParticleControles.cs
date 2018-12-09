using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleControles : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * 10.0f);
        Destroy(this.gameObject, 15f);

	}


    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<MonsterStats>().HP > 0)
        {
            other.GetComponent<MonsterStats>().HP -= 5;
        }
        Destroy(this.gameObject);
    }
}
