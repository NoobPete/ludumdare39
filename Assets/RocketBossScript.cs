using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBossScript : MonoBehaviour {
    public GameObject rocketUpPrefab;
    public GameObject rocketDownPrefab;
    public Transform[] firePositions;
    public Transform downPositionMiddle;
    public int attackMode = 1;
    private float timer = 0f;
    private int stage = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer>2f && stage == 1)
        {
            timer = 0f;
            SpawnDownRocket(UnityEngine.Random.Range(-100,100));
        }
	}

    private void SpawnDownRocket(int location)
    {
        GameObject o = Instantiate(rocketDownPrefab, downPositionMiddle.transform.position, Quaternion.Euler(180, 0, 0));
        o.transform.position = new Vector3(o.transform.position.x, o.transform.position.y + location / 100f);
    }

    public void FireMissiel(int round)
    {
        switch (attackMode)
        {
            case 1:
                for (int i = 0; i < 4; i++)
                {
                    Instantiate(rocketUpPrefab, firePositions[i].position, Quaternion.identity);
                }
                break;
            case 2:
                if (round % 2 == 0)
                {
                    Instantiate(rocketUpPrefab, firePositions[0].position, Quaternion.identity);
                    Instantiate(rocketUpPrefab, firePositions[2].position, Quaternion.identity);
                } else
                {
                    Instantiate(rocketUpPrefab, firePositions[1].position, Quaternion.identity);
                    Instantiate(rocketUpPrefab, firePositions[3].position, Quaternion.identity);
                }
                
                break;

        }
    }
}
