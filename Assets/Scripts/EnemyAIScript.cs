using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIScript : MonoBehaviour
{
    public int movementSpeed = 200;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Check if player is close enough to start pursuit
        GameObject closestsPlayer = GameControllerScript.main.GetClosestPlayer(this);

        if (Vector2.Distance(gameObject.transform.position, closestsPlayer.transform.position) < 10)
        {
            if (gameObject.transform.position.x < closestsPlayer.transform.position.x)
            {
                // Move right
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * movementSpeed);
            }
            else
            {
                // Move left
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * movementSpeed);
            }
        }
    }
}
