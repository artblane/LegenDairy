using UnityEngine;

public class planet : MonoBehaviour{
public GameObject prefab;

    void PlaceRandomly(GameObject obj)
    {
        if (obj == null) return;

        // Random position for both X and Z axis
        float x = Random.Range(-500f,500f);
        float z = Random.Range(-500f,2000f);
        Vector3 randomPosition = new Vector3(x, 75, z);

        // Set the new position 
        obj.transform.position = randomPosition;
    
    }

    // for loop to instantiate several random orienations of the planet
    void Start () { 
    for(int i = 0; i < 2; ++i)
{
    float xQuat = Random.Range(0.0f,1.0f);
        float yQuat = Random.Range(0.0f,1.0f);
        float zQuat = Random.Range(0.0f,1.0f);
        //Quaternion newQuaternion = new Quaternion();
        //newQuaternion.Set(xQuat, yQuat, yQuat, zQuat);
        //Return the new Quaternion
        
    
    PlaceRandomly(Instantiate(prefab, new Vector3(0,2,0), Quaternion.identity));

    }
    }
}
