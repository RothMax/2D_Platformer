using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float speed = 5f;
    public float acceleration = 2f;
    private Vector2 currentVelocity;

    private Rigidbody2D rb;
    //private SpriteRenderer spriteRenderer;
    //private Animator animator

    //private bool isPlayerAlive;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //animator = GetComponent<Animator>();
    }

    void Update()
    {

    }



    // Will make Movement later
}