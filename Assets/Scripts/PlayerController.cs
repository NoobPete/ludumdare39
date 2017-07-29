using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [HideInInspector] public bool facingRight = true;
    [HideInInspector] public bool jump = false;
    public float moveForce = 365f;
    public float maxSpeed = 5f;
    public float jumpForce = 1000f;
    public Transform groundCheck;
    public string jumpKey, leftRightKey, upDownKey, normalFireKey;
    public GameObject bulletPrefab;
    public Transform bulletLocation;

    private Animator legAnimator;
    public GameObject legs;
    public float walkAnimationStart;
    public float walkAnimationSpeed;

    private bool grounded = false;
    //private Animator anim;
    private Rigidbody2D rb2d;


    // Use this for initialization
    void Awake()
    {
        legAnimator = legs.GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        legAnimator.SetBool("Grounded", grounded);

        if (Input.GetButtonDown(jumpKey) && grounded)
        {
            jump = true;
        }

        if (Input.GetButtonDown(normalFireKey))
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletLocation.position, Quaternion.identity);
            if (facingRight == false)
            {
                bullet.GetComponent<BulletScript>().speed = bullet.GetComponent<BulletScript>().speed * -1;
            }
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis(leftRightKey);

        legAnimator.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x)*walkAnimationSpeed);
        if (walkAnimationStart <= Mathf.Abs(rb2d.velocity.x))
        {
            legAnimator.SetBool("Moveing", true);
        } else
        {
            legAnimator.SetBool("Moveing", false);
        }

        if (h * rb2d.velocity.x < maxSpeed)
            rb2d.AddForce(Vector2.right * h * moveForce);

        if (Mathf.Abs(rb2d.velocity.x) > maxSpeed)
            rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

        if (h > 0 && !facingRight)
            Flip();
        else if (h < 0 && facingRight)
            Flip();

        if (jump)
        {
            legAnimator.SetTrigger("Jump");
            rb2d.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }
    }


    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
