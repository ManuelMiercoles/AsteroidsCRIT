using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int score;
    //public GameObject Pickup;
    public GameObject asteroid;
    
    //int pickupNumber = 10;

    public Text scoretext;

    GameObject player;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("spawnProcess");


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
               
            }
    }
}
    public void incrementScore()
    {
        score++;
        GameObject obj = GameObject.Find("scoretext");
        scoretext.text = "Score: " + score;
        Debug.Log("score: " + score);
    }

}