using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEnemyAniControllerScript : MonoBehaviour {
    private Animator legAnimator;
    public GameObject legs;
    public Transform groundCheck;
    private Rigidbody2D rb2d;
    public float walkAnimationStart = .1f;
    public float walkAnimationSpeed = .3f;

    // Use this for initialization
    void Start()
    {
        legAnimator = legs.GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        bool grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        legAnimator.SetBool("Grounded", grounded);

        legAnimator.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x) * walkAnimationSpeed);
        if (walkAnimationStart <= Mathf.Abs(rb2d.velocity.x))
        {
            legAnimator.SetBool("Moveing", true);
        }
        else
        {
            legAnimator.SetBool("Moveing", false);
        }
    }
}
