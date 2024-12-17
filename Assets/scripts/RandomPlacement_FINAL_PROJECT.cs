

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class GameController : MonoBehaviour
{
    // Player's score and health
    public int score = 0;
    public int health = 100;

    // GameObject references for random placement (should be assigned in Inspector)
    public GameObject PlanetBlane;
    public GameObject PlanetAthena;
    public GameObject PlanetLindsey;
    public GameObject PlanetNicole;
    public GameObject fuelPack;
    public GameObject SpaceCow;
    public GameObject Ship;
    public GameObject finishLine;
     public GameObject asteroid;

    // Player GameObject (assign the player's sphere in the Inspector)
    public GameObject player;

    // Tags for the different objects
    private const string FUELPACK_TAG = "";
    private const string PLANET_TAG = "Owww";
    private const string SHIP_TAG = "LETS GO";
    private const string FINISHLINE_TAG = "FinishLine";

    void Start()
    {
        // Randomly place objects
        PlaceRandomly(PlanetBlane);
        PlaceRandomly(PlanetAthena);
        PlaceRandomly(PlanetLindsey);
        PlaceRandomly(PlanetNicole);
        PlaceRandomly(FuelPack1);
        PlaceRandomly(FuelPack2);
        PlaceRandomly(FuelPack3);
        PlaceRandomly(FuelPack4);
        PlaceRandomly(SpaceCow);
        PlaceRandomly(Ship);
        PlaceRandomly(finishLine);
        PlaceRandomly(Asteroid)
    }

    void Update()
    {
        // Check for health, and display "Game Over" if health is 0 or below
        if (health <= 0)
        {
            Debug.Log("Game Over");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Handle collision with planets (subtract 25 from health)
        if (collision.gameObject.CompareTag(PLANET_TAG))
        {
            health -= 25;
            if (health <= 0)
            {
                Debug.Log("Game Over");
            }
        }

        // Handle collision with fuelpack (increase score by 10)
        if (collision.gameObject.CompareTag(FUELPACK_TAG))
        {
            score += 10;
            Debug.Log("Score: " + score);
        }

        // Handle collision with finish line (display success message)
        if (collision.gameObject.CompareTag(FINISHLINE_TAG))
        {
            Debug.Log("You have reached the finish line");
        }
    }

    // Function to place objects randomly on the gameboard
    void PlaceRandomly(GameObject obj)
    {
        if (obj == null) return;

        // Random position between -25 and 25 for both X and Z axis
        float x = Random.Range(-25f, 25f);
        float z = Random.Range(-25f, 25f);
        Vector3 randomPosition = new Vector3(x, 0, z);

        // Set the new position of the object
        obj.transform.position = randomPosition;
    }
}
*/