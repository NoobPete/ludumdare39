using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthInvisibleScript : MonoBehaviour {
    public float health;
    private float maxHealth;
    public bool canTakeDamage = false;
    public GameObject levelChanger;

	// Use this for initialization
	void Start () {
        health = health * PlayerPrefs.GetInt("PlayerCount");
        maxHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    internal bool ChangeLevel(int amount)
    {
        if (canTakeDamage)
        {
            health = Mathf.Clamp(health + amount, 0, maxHealth);

            if (health == 0)
            {
                if (levelChanger != null)
                {
                    Instantiate(levelChanger);
                }
                return true;
            }

            return false;
        }
        return false;
    }
}
