﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomChangerScript : MonoBehaviour {
    public float delay = 4f;
    private float timer = 0;
    public int targetRoom = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer > delay)
        {
            SceneManager.LoadScene(targetRoom);
        }
	}
}
