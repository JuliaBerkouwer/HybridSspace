using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStats : MonoBehaviour {

    public int HP = 10;
    public GameObject hpBar;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        hpBar.transform.localScale = new Vector3(0.05f * HP, 0.4f, 0.1f);
	}
}
