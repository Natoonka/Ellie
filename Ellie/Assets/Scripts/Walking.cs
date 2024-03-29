﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        if (move > 0.0)
        {
            transform.localScale = new Vector2(1, 1);
        }
        if (move < 0.0)
        {
            transform.localScale = new Vector2(-1, 1);
        }
        rb.velocity = new Vector2(move*speed, 0);
    }
}
