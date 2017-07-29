using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthInvisibleScript : MonoBehaviour {
    public float health;
    private float maxHealth;

	// Use this for initialization
	void Start () {
        maxHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    internal bool ChangeLevel(int amount)
    {
        health = Mathf.Clamp(health + amount, 0, maxHealth);

        if (health == 0)
        {
            return true;
        }

        return false;
    }
}
