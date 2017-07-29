using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    private BatteryFillScript fill;

	// Use this for initialization
	void Start () {
        fill = GetComponent<BatteryFillScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {        
        if (collision.gameObject.GetComponent<BulletScript>() != null)
        {
            Destroy(collision.gameObject);
            if (fill.ChangeLevel(-35))
            {
                Destroy(gameObject);
            }
        }
    }
}
