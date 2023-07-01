using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FireballSpawner : MonoBehaviour
{
    public GameObject obstacle;

    float timer;
    public float maxTime;
    public float maxY;
    public float minY;
    float randomY;

    public void InstantiateObstacle() //onje olu�turacak s�n�f
    {
        randomY = Random.Range(minY, maxY);

        GameObject newObstacle = Instantiate(obstacle); //neyi olu�uturaca��z

        newObstacle.transform.position = new Vector2(transform.position.x, randomY);
    }

    // Start is called before the first frame update
    void Start()
    {
        
        //InstantiateObstacle();
    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.gameOver == false && GameManager.gameStarted == true)
        {

            timer += Time.deltaTime;

            if (timer >= maxTime)

            {
                InstantiateObstacle();
                timer = 0;
            }
        }


    }
}
//s�rekli obje �retip yok etmek sa�l�kl� de�il farkl� y�ntem tercih edilir objectpool gibi