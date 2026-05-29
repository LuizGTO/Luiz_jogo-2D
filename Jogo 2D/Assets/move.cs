using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class move : MonoBehaviour
{
    public Rigidbody2D rb2d;
       void Start()
    {
        rb2d = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("horizontal");
        if (rb2d.linearVelocity.magnitude < 5)
        {
            rb2d.linearVelocity += new Vector2(1,0)*horizontalInput*Time.deltaTime;
        }
    }
}
