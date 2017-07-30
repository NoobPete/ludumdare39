using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCloseDamageScript : MonoBehaviour {
    public float timeMeasurement = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeMeasurement += Time.deltaTime;

        List<PlayerController> alreadyHit = new List<PlayerController>();
        foreach (RaycastHit2D rc in Physics2D.BoxCastAll(transform.position, new Vector2(2.2f, 4.4f), 0f, new Vector2(0, 0)))
        {
            PlayerController player = rc.transform.GetComponent<PlayerController>();
            if (player != null)
            {
                if (!alreadyHit.Contains(player))
                {
                    alreadyHit.Add(player);
                    player.Damage(20);
                }
            }
        }
    }
}
