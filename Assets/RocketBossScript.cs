using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBossScript : MonoBehaviour {
    public GameObject rocketUpPrefab;
    public Transform[] firePositions;
    public int attackMode = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
