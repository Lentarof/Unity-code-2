using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        //Refering to itself gameobject 
        // food collide with something and destroys
        /*  Destroy(gameObject);*/
        //Reference to the other gameobject who's collide
        // animal collide with food and destroys
        /* Destroy(other.gameObject);*/
        //Method that I apply before
        /*if (other.gameObject.CompareTag("Enemy"))
        {

        }*/

        //Document Method
        if (other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }//Check if the other tag was an Animal"Enemy", if so add points to the score
        else if(other.CompareTag("Enemy"))
        {
            //Whitout the slider it will wort this AddScore(5)
            // gameManager.AddScore(5);
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(gameObject);
            //Whit the Addscore 
            //Destroy(other.gameObject);
        }
    }
}
