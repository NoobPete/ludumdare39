using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Animator ani = GetComponent<Animator>();
        ani.SetBool("Grounded", true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
