using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public GameObject[] player;
    public static GameControllerScript main;

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
            if (Vector2.Distance(player[i].transform.position, transform.transform.position) < smallestDistanceYet)
            {
                smallestDistanceYet = Vector2.Distance(player[i].transform.position, transform.transform.position);
                result = player[i];
            }
        }
        return result;
    }
}
