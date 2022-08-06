using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMoving : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;
    private Vector2 movement;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        anim.SetBool("isWalking", movement != Vector2.zero);
        if (movement != Vector2.zero)
        {
            anim.SetFloat("X", movement.x);
            anim.SetFloat("Y", movement.y);
        }
    }
    private void FixedUpdate()
    {
        body.MovePosition(body.position + movement.normalized * speed * Time.fixedDeltaTime);
    }
}