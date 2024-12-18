using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    public float health, MaxHealth;
    public float playerSpeed = 200f;
    public float rotationSpeed = 20f;
    //healthbar UI 
    [SerializeField]
    private HealthBarUI healthBar;

//set health at start
    void Start () {
        healthBar.SetMaxHealth(MaxHealth);
    Debug.Log("health = " + health);
    }
   
   
    void FixedUpdate ()
    {

    
//player movements
    float horizontalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");   
    
    GetComponent<Rigidbody>().AddForce(-transform.right * verticalInput * playerSpeed);
    transform.Rotate(0,horizontalInput * rotationSpeed * Time.deltaTime,0);

    }
    
    
public void SetHealth(float healthChange){
    health += healthChange;
    health = Mathf.Clamp(health, 0, MaxHealth);
    healthBar.SetHealth(health);
}
//asteroid, healthpack, and planet triggers
    public void OnTriggerEnter(Collider other){
        
        if(other.gameObject.CompareTag("healthPack")){
        SetHealth(10f);
        Debug.Log("HEALTH PACK GET, health is now "+ health);
        Destroy(other.gameObject);
        }
        else if(other.gameObject.CompareTag("asteroid")){
        SetHealth(-20f);
        Debug.Log("OUCH! health is now= "+ health);
        }
        else if(other.gameObject.CompareTag("planet")){
        SetHealth(-30f);
        Debug.Log("BIG OUCH! health is now= "+ health);
        }

        // check for health game over 
if (health <= 0)
        {
            Debug.Log("Game Over");
        }
        }
    }




