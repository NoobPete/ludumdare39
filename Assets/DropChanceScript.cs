using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropChanceScript : MonoBehaviour {
    public GameObject droppedItem;
    public float chance = 100f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnDestroy()
    {
        if (Random.Range(0f, 100f) <= chance)
        {
            Instantiate(droppedItem, transform.position, Quaternion.identity);
        }
    }
}
