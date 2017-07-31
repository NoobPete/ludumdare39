using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public int horizontalSpeed = 6;
    public int verticalSpeed = 0;
    public bool bulletFacingRight = true;
    public bool bulletFacingUpwards = false;
    private bool makeEffect = true;
    public GameObject hitParticals;

    // Use this for initialization
    void Start()
    {
        var r2d = GetComponent<Rigidbody2D>();

        r2d.velocity = new Vector3(horizontalSpeed, verticalSpeed);

        if (bulletFacingRight == false)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
        if (bulletFacingUpwards == true)
        {
            transform.Rotate(new Vector3(0, 0, 90));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnBecameInvisible()
    {
        // Destroy the bullet 
        Destroy(gameObject);
    }

    void OnDestroy()
    {
        if (makeEffect)
        {
            Destroy(Instantiate(hitParticals, transform.position, Quaternion.identity), 2);
        }
    }
}