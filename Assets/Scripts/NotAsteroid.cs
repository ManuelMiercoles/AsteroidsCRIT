using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotAsteroid : MonoBehaviour {
    public GameObject particle2;
    public float forceY = -500;
    //float randY = 0;

    Rigidbody2D rb;

    Player player;
    GameController gc;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

        float randX = Random.Range(-4.2f, 4.2f);
        Vector3 pos = transform.position;
        pos.x = randX;
        transform.position = pos;

        rb.AddForce(new Vector2(forceY, 0));

        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        GameObject obj = GameObject.FindGameObjectWithTag("Player");
        if(obj != null)
        {
            player = obj.GetComponent<Player>();
        }
    }

    // Update is called once per frame
    void Update()
    {

        //Vector3 pos = transform.position;
       // pos.x += -3.0f * Time.deltaTime;
       // pos.y = Mathf.Cos(pos.x);
        //transform.position = pos;
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("Collision detected");
        if(col.tag == "Player")
        {
            Instantiate(particle2, col.gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
            gc.incrementScore();
        }
        //if (col.tag == "Player")
        //{
           // player.hurt(25);
            //Destroy(col.gameObject);
        }
    }
    

