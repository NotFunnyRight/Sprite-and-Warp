using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    [SerializeField] float speed = 10000f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Vector3 scale = transform.localScale;
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-speed * Time.deltaTime, 0);
            scale.x = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(speed * Time.deltaTime, 0);
            scale.x = 1;
        }

        animator.SetBool("IsRunning", true);
        transform.localScale = scale;

        if( Mathf.Abs( rb.velocity.x) < 0.5)
        {
            animator.SetBool("IsRunning", false);
        }
    }

    private void FoxedUpdate()
    {

    }
}
