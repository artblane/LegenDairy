using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float health, MaxHealth;
    public AudioSource AudioPlayerHealth;

    public AudioSource AudioPlayerCrash;

    public AudioSource AudioPlayerPlanetCrash;

    public AudioSource AudioPlayerFinishLine;
    

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
        AudioPlayerHealth.Play();
        Destroy(other.gameObject);
        }
        else if(other.gameObject.CompareTag("asteroid")){
        SetHealth(-5f);
        Debug.Log("OUCH! health is now= "+ health);
        AudioPlayerCrash.Play();
        }
        else if(other.gameObject.CompareTag("planet")){
        SetHealth(-15f);
        Debug.Log("BIG OUCH! health is now= "+ health);
        AudioPlayerPlanetCrash.Play();
        }
         else if(other.gameObject.CompareTag("finishLine")){
            Debug.Log("you hit the finishline");
        AudioPlayerFinishLine.Play();
        }

        // check for health game over 
if (health <= 0)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene("Lose"); 
        }
        }
    }




