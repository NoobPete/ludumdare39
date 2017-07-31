using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBossScript : MonoBehaviour {
    public GameObject hitParticals;
    public GameObject rocketUpPrefab;
    public GameObject rocketDownPrefab;
    public Transform[] firePositions;
    public Transform downPositionMiddle;
    public Transform leftSpawn;
    public Transform rightSpawn;
    public GameObject mellee;
    public GameObject shooting;
    public GameObject health;
    public int attackMode = 2;
    public float timer = 0f;
    public int stage = 0;

    private Animator ani;

    // Use this for initialization
    void Start () {
		ani = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer>6f && stage<7 && stage != 0)
        {
            timer = 4.5f;
            stage++;
            SpawnDownRocket(UnityEngine.Random.Range(-5.5f,5.5f));
        }

        if (timer>8f && stage == 7)
        {
            stage++;
            SpawnLeft(mellee);
            SpawnRight(mellee);
        }

        if (timer > 9f && stage == 8)
        {
            stage++;
            ani.SetTrigger("Trigger");
            SpawnLeft(health);
            SpawnRight(health);

            if (GetComponent<HealthInvisibleScript>().health > PlayerPrefs.GetInt("PlayerCount")*750)
            {
                timer = 0;
                stage = 1;

                SpawnLeft(shooting);
                SpawnRight(shooting);
            }
        }

        if (timer > 14f && stage > 8 && stage < 16)
        {
            timer = 13f;
            stage++;
            SpawnDownRocket(UnityEngine.Random.Range(-5.5f, 5.5f));

            float number = UnityEngine.Random.Range(0f, 10f);
            if (number < 1)
            {
                SpawnLeft(mellee);
                SpawnRight(shooting);
            } else if (number < 2)
            {
                SpawnRight(mellee);
                SpawnLeft(shooting);
            }
        }

        if (timer > 16f && stage == 16)
        {
            stage=9;
            timer = 9;
            ani.SetTrigger("Trigger");
            SpawnLeft(mellee);
            SpawnRight(mellee);
            SpawnLeft(mellee);
            SpawnRight(mellee);
        }
    }

    private void SpawnRight(GameObject mellee)
    {
        Instantiate(mellee, rightSpawn.position, Quaternion.identity);
    }

    private void SpawnLeft(GameObject mellee)
    {
        Instantiate(mellee, leftSpawn.position, Quaternion.identity);
    }

    private void SpawnDownRocket(float location)
    {
        GameObject o = Instantiate(rocketDownPrefab, downPositionMiddle.transform.position, Quaternion.Euler(180, 0, 0));
        o.transform.position = new Vector3(o.transform.position.x + location, o.transform.position.y);
    }

    internal void StartStage()
    {
        ani.SetTrigger("Trigger");
    }

    public void FireMissiel(int round)
    {
        if (stage == 0)
        {
            stage = 1;
            timer = 0;
        }

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

    void OnDestroy()
    {
        Destroy(Instantiate(hitParticals, transform.position, Quaternion.identity), 6);
    }
}
