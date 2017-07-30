using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPackScript : MonoBehaviour {
    public int amount = 20;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController o = collision.gameObject.GetComponent<PlayerController>();
        if (o != null)
        {
            o.Heal(amount);

            Destroy(gameObject);

            
        }
    }
}
