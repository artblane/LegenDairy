using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    // Player's health 
    public int health = 100;

    public float playerSpeed = 200f;
    public float rotationSpeed = 2f;

    public float xAngle, yAngle, zAngle;

    void Start () {
    Debug.Log("health = " + health);
    }
   
   //movement script

   
    void Update ()
    {
    float horizontalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");   
    
    transform.Translate(Vector3.left * verticalInput * playerSpeed * Time.deltaTime);  
    transform.Translate(Vector3.down * horizontalInput * playerSpeed * Time.deltaTime);
    //transform.Rotate(0, Input.GetAxis("Horizontal")* rotationSpeed * Time.deltaTime, 0);
    //transform.Rotate(Input.GetAxisxAngle, yAngle, zAngle, Space.World);

    

    // check for health game over 
if (health <= 0)
        {
            Debug.Log("Game Over");
        }
    }
    
    
    // asteroid collission script

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("asteroid"))
        health = health - 10;
        Debug.Log("health = "+ health);
    
        //if(other.gameObject.CompareTag("fuelPack"))
        //health = health + 10;
        //Debug.Log("health = "+ health);
        //}
    }
}

    

