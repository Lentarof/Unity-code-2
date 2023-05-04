using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float instantionTimer = 2f;
    // Update is called once per frame
    void Update()
    {
        CreateDogPrefab();
    }
    void CreateDogPrefab()
    {
        //Allow us to put a timer or an interval on the instantion of the dogs, resting the value every frame
        instantionTimer -= Time.deltaTime;
        //if the timer is zero, it will let you instantiate a dog
        if (instantionTimer <= 0)
        { 
            
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                instantionTimer = 2f;
            }
        }
    }
}
