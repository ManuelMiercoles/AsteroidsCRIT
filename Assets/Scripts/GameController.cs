using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int score = 100;
    //public GameObject Pickup;
    public GameObject asteroid;

    //int pickupNumber = 10;

    public Text scoretext;
   
   

    GameObject player;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("spawnProcess");
        GameObject.Find("scoretext").SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator spawnProcess()
    {
        while (true)
        {
            int aynrand = Random.Range(0, 3);
            int s = 0;

            switch (aynrand)
            {
                case 0:
                    //  for (int i = 0; i < 25; i++)
                    {
                        yield return new WaitForSeconds(1.0f);
                        Instantiate(asteroid);
                        s++;
                    }
                    break;
                case 1:
                    // for (int i = 0; i < pickupNumber; i++)
                    {
                        yield return new WaitForSeconds(1.0f);
                        Instantiate(asteroid);
                        s++;
                    }
                    break;
                case 3:
                    // for (int i = 0; i < pickupNumber; i++)
                    {
                        yield return new WaitForSeconds(1.0f);
                        Instantiate(asteroid);
                        s++;
                    }
                    break;

            }
            if (s == 30)
            {
                GameObject.Find("scorecanvas").SetActive(true);
            }
        }
    }
    public void incrementScore()
    {
       // score = -1;
        GameObject obj = GameObject.Find("scoretext");
        scoretext.text = "Score: " + score ;
        Debug.Log("score: " + score);
   }
    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("Collision detected");
        if (col.tag == "Player")
        {
            score = -1;
            GameObject obj = GameObject.Find("scoretext");
            scoretext.text = "Score: " + score + "Percent";
            Debug.Log("score: " + score);
            Destroy(gameObject);


        }

    }
}