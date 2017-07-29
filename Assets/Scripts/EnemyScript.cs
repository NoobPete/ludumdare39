using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    private BatteryFillScript fill;
    private HealthInvisibleScript health;

	// Use this for initialization
	void Start () {
        fill = GetComponent<BatteryFillScript>();
        health = GetComponent<HealthInvisibleScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {        
        if (collision.gameObject.GetComponent<BulletScript>() != null)
        {
            Destroy(collision.gameObject);

            if (fill != null)
            {
                if (fill.ChangeLevel(-35))
                {
                    Destroy(gameObject);
                }
            }

            if (health != null)
            {
                if (health.ChangeLevel(-35))
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
