using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRightDirectionTowardsClosestPlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject o = GameControllerScript.main.GetClosestPlayer(transform);
        transform.LookAt(o.transform);
        transform.Rotate(new Vector3(0, 90, 0));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
