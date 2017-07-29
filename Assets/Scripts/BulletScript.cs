using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public int speed = 6;

	// Use this for initialization
	void Start () {
        var r2d = GetComponent<Rigidbody2D>();

        r2d.velocity = new Vector3(speed, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnBecameInvisible()
    {
        // Destroy the bullet 
        Destroy(gameObject);
    }
}
