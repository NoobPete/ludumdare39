﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardScript : MonoBehaviour {
    public float speed;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        transform.position -= transform.right * Time.deltaTime * speed;

    }
}