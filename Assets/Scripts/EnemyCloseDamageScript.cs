using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCloseDamageScript : MonoBehaviour
{
    public float timeMeasurement;

    // Use this for initialization
    void Start()
    {
        timeMeasurement = 4;
    }

    // Update is called once per frame
    void Update()
    {
        timeMeasurement += Time.deltaTime;

        if (timeMeasurement >= 3)
        {
            List<PlayerController> alreadyHit = new List<PlayerController>();
            foreach (RaycastHit2D rc in Physics2D.BoxCastAll(transform.position, new Vector2(1.1f, 1.9f), 0f, new Vector2(0, 0)))
            {
                PlayerController player = rc.transform.GetComponent<PlayerController>();
                if (player != null)
                {
                    if (!alreadyHit.Contains(player))
                    {
                        alreadyHit.Add(player);
                        player.Damage(20);
                        timeMeasurement = 0;
                    }
                }
            }
        }

    }
}
