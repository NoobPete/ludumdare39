using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnFirstFrame : MonoBehaviour {
    bool firstFrame = true;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void LateUpdate () {
        if (!firstFrame)
        {
            Destroy(gameObject);
        }
        firstFrame = false;
    }
}
