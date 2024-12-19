using UnityEngine;
using UnityEngine.SceneManagement;  // For scene management

public class RingTrigger : MonoBehaviour
{
    // This will trigger the scene change when the player passes through the ring
    public string Win = "Win";  // Name of the scene to load when the player wins

    // When another object enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the player passed through the ring (you can tag your player or check for a specific object)
        if (other.CompareTag("player"))  // Ensure the player has the tag "Player"
        {
            Debug.Log("You passed through the ring! You Win!");

            // Load the "You Win" scene
            SceneManager.LoadScene(Win);
        }
    }
}