using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float leftRightBound = 30.0f;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //If an object past the bound view, it destroys
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound) 
        {
            //When the stampid who comes in front pass the lower bound you lose
            // Debug.Log("Game Over");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }

        if (transform.position.x > leftRightBound)
        {
            //gameManager can be apply here like the previus else if
            Destroy(gameObject);
        } else if (transform.position.x < -leftRightBound) 
        {
            //gameManager can be apply here like the previus else if
            Destroy(gameObject);
        }
    }
}
