using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public GameObject[] player;
    public static GameControllerScript main;
    public AudioSource[] jumpSound;
    public AudioSource[] shootSound;
    public AudioSource[] deathSound;
    public AudioSource[] enemyDeathSound;
    public AudioSource[] hitSound;
    public AudioSource[] enemyHitSound;
    public AudioSource[] explosionSound;
    public AudioSource[] bulletCollsionSound;

    // Use this for initialization
    void Start()
    {
        main = this;
        if (PlayerPrefs.GetInt("PlayerCount") == 1)
        {
            Destroy(player[1]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    internal GameObject GetClosestPlayer(Transform transform)
    {
        float smallestDistanceYet = float.MaxValue;
        GameObject result = null;

        for (int i = 0; i < player.Length; i++)
        {
            if (player[i] == null)
            {
                continue;
            }
            if (Vector2.Distance(player[i].transform.position, transform.transform.position) < smallestDistanceYet)
            {
                smallestDistanceYet = Vector2.Distance(player[i].transform.position, transform.transform.position);
                result = player[i];
            }
        }
        return result;
    }

    public void PlayJumpSound()
    {
        jumpSound[UnityEngine.Random.Range((int)0, jumpSound.Length - 1)].Play();
    }

    public void PlayShootSound()
    {
        shootSound[UnityEngine.Random.Range((int)0, shootSound.Length - 1)].Play();
    }

    public void PlayDeathSound()
    {
        deathSound[UnityEngine.Random.Range((int)0, deathSound.Length - 1)].Play();
    }

    public void PlayHitSoundSound()
    {
        hitSound[UnityEngine.Random.Range((int)0, hitSound.Length - 1)].Play();
    }

    public void PlayEnemyHitSound()
    {
        enemyHitSound[UnityEngine.Random.Range((int)0, enemyHitSound.Length - 1)].Play();
    }

    public void PlayExplosionSound()
    {
        explosionSound[UnityEngine.Random.Range((int)0, explosionSound.Length - 1)].Play();
    }

    public void PlayBulletCollision()
    {
        bulletCollsionSound[UnityEngine.Random.Range((int)0, bulletCollsionSound.Length - 1)].Play();
    }
}
