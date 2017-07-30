using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketFlyDownScript : MonoBehaviour {

    public float speed = 5;

    public Transform groundCheck;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 1, 0) * Time.deltaTime * speed;


        bool grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        if (grounded)
        {
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
            GameControllerScript.main.PlayExplosionSound();
            Destroy(gameObject);
        }
    }
}
