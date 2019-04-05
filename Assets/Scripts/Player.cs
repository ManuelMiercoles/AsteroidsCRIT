using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    

    Rigidbody2D rb;

    public int hp = 100;
    
    
    float maxVelX = 5.0F;
    public float buzzkill = 5f;
    public float buzzkill2 = 1f;

    
    
    float limitXLeft = -2.86f;
    float limitXRight = 2.86f;


    public float forceX = 20.0f;

   

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.acceleration.x, 0, 0);

        /* float valX = Input.GetAxis("Horizontal");


         float moveX = valX * forceX;

         rb.AddForce(new Vector2(moveX, 0));

         Vector2 velocity = rb.velocity;

         if (velocity.x > maxVelX)
         {
             velocity.x = maxVelX;
         }
         if (velocity.x < -maxVelX)
         {
             velocity.x = -maxVelX;
         }

         if (valX == 0)
         {
             if (velocity.x > 0.1f)
             {
                 rb.AddForce(new Vector2(0, -5));
             }
             else if (velocity.x < -0.1f)
             {
                 rb.AddForce(new Vector2(0, 5));
             }
             else
             {
                 velocity.x = 0;
             }

         }
         rb.velocity = velocity;



         Vector3 pos = transform.position;


         transform.position = pos;
     */





        Vector3 pos = transform.position;

        if(pos.x < limitXLeft)
        {
            pos.x = limitXLeft;
        }
        if (pos.x < limitXLeft)
        {
            pos.x = limitXRight;
        }
        if (pos.x > limitXRight)
        {
            pos.x = limitXRight;
        }
        transform.position = pos;


        /*Vector3 pos = transform.position;
        pos.y += valY * velY * Time.deltaTime;
        transform.position = pos;*/

        /* rb.AddForce(new Vector2(0, valY * velY));
         Vector2 velocity = rb.velocity;
         if(velocity.y > maxVelY)
         {
             velocity.y = maxVelY;
         }
         if(velocity.y < -maxVelY)
         {
             velocity.y = -maxVelY;
         }
         if(valY == 0)
         {
             if (velocity.y > -0.2f && velocity.y < 0.2f)
             {
                 velocity.y = 0;
             }
             else if (velocity.y > 0)
             {
                 rb.AddForce(new Vector2(0, -3.0f));
             }  
             else if(velocity.y < 0)
             {
                 rb.AddForce(new Vector2(0, 3.0f));
             }

         }
         rb.velocity = velocity;*/
    }

    public void hurt(int damage)
    {
        hp -= damage; 
        if(hp <= 0)
        { 
            hp = 0;
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("Collision detected");
        if (col.tag == "Enemy")
        {
            forceX = forceX - buzzkill;
            maxVelX = maxVelX - buzzkill2;
            Destroy(col.gameObject);
        }
        //if (col.tag == "Player")
        //{
        // player.hurt(25);
        //Destroy(col.gameObject);
    }

}

