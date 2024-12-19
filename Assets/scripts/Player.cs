using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float health, MaxHealth;
    public float playerSpeed = 200f;
    public float rotationSpeed = 20f;

    // Healthbar UI
    [SerializeField]
    private HealthBarUI healthBar;

    // Set health at start
    void Start()
    {
        healthBar.SetMaxHealth(MaxHealth);
        Debug.Log("health = " + health);
    }

    void FixedUpdate()
    {
        // Player movements
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().AddForce(-transform.right * verticalInput * playerSpeed);
        transform.Rotate(0, horizontalInput * rotationSpeed * Time.deltaTime, 0);
    }

    public void SetHealth(float healthChange)
    {
        health += healthChange;
        health = Mathf.Clamp(health, 0, MaxHealth);
        healthBar.SetHealth(health);

        // Check for game over when health reaches zero
        if (health <= 0)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene("Lose"); // Transition to Lose scene
        }
    }

    // Asteroid, health pack, and planet triggers
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("healthPack"))
        {
            SetHealth(10f);
            Debug.Log("HEALTH PACK GET, health is now " + health);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("asteroid"))
        {
            SetHealth(-5f);
            Debug.Log("OUCH! health is now= " + health);
        }
        else if (other.gameObject.CompareTag("planet"))
        {
            SetHealth(-15f);
            Debug.Log("BIG OUCH! health is now= " + health);
        }
    }
}
