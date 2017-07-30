using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtEnemyScript : MonoBehaviour {
    public GameObject bullet;
    float timer = 0f;
    public float shootingSpeed;
    public float range = 10;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject closestsPlayer = GameControllerScript.main.GetClosestPlayer(transform);
        if (Vector2.Distance(gameObject.transform.position, closestsPlayer.transform.position) < 10)
        {
            timer += Time.deltaTime;

            if (timer > shootingSpeed)
            {
                timer -= shootingSpeed;
                Instantiate(bullet, transform.position, Quaternion.identity);
            }
        }
	}
}
