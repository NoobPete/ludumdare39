using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessSpawnerScript : MonoBehaviour {
    public GameObject mell;
    public GameObject shooter;
    public GameObject create;
    public bool started = false;
    private float timer = 0f;
    public float activateDistance;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(GameControllerScript.main.GetClosestPlayer(transform).transform.position, transform.position) < activateDistance)
        {
            started = true;
        }
		if (started)
        {
            timer += Time.deltaTime;

            if (timer > 1f)
            {
                timer = 0f;
                Instantiate(create, transform.position, Quaternion.identity);
                Instantiate(mell, transform.position, Quaternion.identity);
                Instantiate(shooter, transform.position, Quaternion.identity);
            }
        }
	}
}
