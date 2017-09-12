using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public float health = 100f;

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;

        Debug.Log("player " + health);

        if (health <= 0)
        {

        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
