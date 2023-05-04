using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float speedVertical = 10.0f;
    public float xRange = 20.0f;
    public float zRange = 16.0f;
    public float zRangeNegative = 2.0f;

    public GameObject projectilPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Bounds on the x position
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
       
        if (transform.position.x > xRange) 
        { 
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //Bounds on the z position
        if (transform.position.z < -zRangeNegative) 
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRangeNegative);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
      
        //Movement of the player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speedVertical);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            //Instantiate is useful if you want to create a copy of an existence object in this case the projectile
            Instantiate(projectilPrefab, transform.position + Vector3.forward * 2f, projectilPrefab.transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Game Over");
    }
}
