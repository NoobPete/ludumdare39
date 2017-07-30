using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    public GameObject player1;
    public GameObject player2;
    public float distance;
    public float upDown;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (player2 != null && player1 != null)
        {
            transform.position = player1.transform.position + (player2.transform.position - player1.transform.position) / 2 + new Vector3(0, upDown, distance);
        } else if (player2 == null)
        {
            transform.position = player1.transform.position + new Vector3(0, upDown, distance);
        } else if (player1 == null)
        {
            transform.position = player2.transform.position + new Vector3(0, upDown, distance);
        }
	}
}
