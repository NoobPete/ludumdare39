using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOnGroundHitScript : MonoBehaviour {
    public Transform groundCheckerPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        bool grounded = Physics2D.Linecast(transform.position, groundCheckerPoint.position, 1 << LayerMask.NameToLayer("Ground"));

        if (grounded)
        {
            GameControllerScript.main.PlayBulletCollision();
            Destroy(gameObject);
        }
    }
}
