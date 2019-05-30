using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donotpickup : MonoBehaviour
{
    public GameObject particle2;
    public GameObject debris;
    public float forceY = -700;
    //float randY = 0;

    Rigidbody2D rb;

    Player player;
    GameController gc;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        float randX = Random.Range(-2.85f, 2.85f);
        Vector3 pos = transform.position;
        pos.x = randX;
        transform.position = pos;

        rb.AddForce(new Vector2(forceY, 0));

        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        GameObject obj = GameObject.FindGameObjectWithTag("Player");
        if (obj != null)
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
        if (col.tag == "Player")
        {
            Instantiate(particle2);
            Instantiate(debris);
            player.hurt(25);
            Destroy(gameObject);
            //Destroy(col.gameObject);
        }
    }

}