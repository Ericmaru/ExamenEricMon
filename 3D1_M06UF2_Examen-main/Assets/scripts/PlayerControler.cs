using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   Rigidbody2D _rigidBody;
   BoxCollider2D _collider;
   public int playerSpeed = 5;
   public int JumpForce = 10;
    private int inputHorizontal;
   
   
   
   
   
   void Awake()
   {
    _rigidBody = GetComponent<Rigidbody2D>();
    _collider = GetComponent<BoxCollider2D>();
   }
   
   
   
   
    void Start()
    {
        
    }

   
    void Update()
    {
     _rigidBody.velocity = new Vector2(inputHorizontal * playerSpeed, _rigidBody.velocity.y);



     Movement();
    }

    void FixedUpdate()
    {
    
    }


    void Movement()
{
    if(inputHorizontal > 0)
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    else if(inputHorizontal < 0)
    {
        transform.rotation = Quaternion.Euler(0, 180, 0);
    }

}

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            _rigidBody.AddForce(new Vector2(10.0f, JumpForce));
        }
    }

}

