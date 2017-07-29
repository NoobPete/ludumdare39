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
            Destroy(gameObject);
        }
    }
}
