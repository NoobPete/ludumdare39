using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public int speed = 6;
    public bool bulletFacingRight = true;

	// Use this for initialization
	void Start () {
        var r2d = GetComponent<Rigidbody2D>();

        r2d.velocity = new Vector3(speed, 0);

        if (bulletFacingRight == false)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
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
