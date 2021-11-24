using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Variables
    [SerializeField] float upForce = 200f;
    bool isDead = false;
    Rigidbody2D rb2d;
    //..

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        IsDead();
    }

    //Metodos
    void Movement()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0, upForce));
        }
    }
    void IsDead()
    {
        if (isDead == true)
        {
            Debug.Log("Player is dead");
        }
    }

    void OnCollisionEnter2D()
    {
        isDead = true;
    }
    //..
}
