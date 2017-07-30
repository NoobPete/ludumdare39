using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCloserScript : MonoBehaviour {
    public GameObject door;
    public RocketBossScript rocketBoss;
    public float doorDistance;
    public float checkDistance;
    private Vector3 origianlPos;
    public bool closed = false;
    private float speed = 2;
    public HealthInvisibleScript h;

    // Use this for initialization
    void Start () {
        origianlPos = door.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (!closed && Vector3.Distance(GameControllerScript.main.GetFarthestPlayer(transform).transform.position, transform.position) < checkDistance)
        {
            if (rocketBoss != null)
            {
                rocketBoss.StartStage();
                h.canTakeDamage = true;
            }
            closed = true;
            
        }

        if (closed)
        {
            door.transform.position = Vector3.MoveTowards(door.transform.position, origianlPos + new Vector3(0, -doorDistance), Time.deltaTime * speed);
        }
	}
}
