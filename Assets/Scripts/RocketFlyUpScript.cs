using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketFlyUpScript : MonoBehaviour {
    public float speed = 5;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 10f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0,1,0) * Time.deltaTime * speed;
	}
}
