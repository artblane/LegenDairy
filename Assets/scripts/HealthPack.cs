using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class healthPack : MonoBehaviour{
public GameObject prefab;


    void PlaceRandomly(GameObject obj)
    {
        if (obj == null) return;

        // Random position for both X and Z axis
        float x = Random.Range(-400f,400f);
        float z = Random.Range(-400f,400f);
        Vector3 randomPosition = new Vector3(x, 75, z);

        // Set the new position and scale of the object
        obj.transform.position = randomPosition;
    
    }

    // for loop to instantiate several random orienations of the asteroid
    void Start () { 
    for(int i = 0; i < 20; ++i)
{
    float xQuat = Random.Range(0.0f,1.0f);
        float yQuat = Random.Range(0.0f,1.0f);
        float zQuat = Random.Range(0.0f,1.0f);
        Quaternion newQuaternion = new Quaternion();
        newQuaternion.Set(xQuat, yQuat, yQuat, zQuat);
        //Return the new Quaternion
        
    
    PlaceRandomly(Instantiate(prefab, new Vector3(0,10,0), newQuaternion));

    }
    }
}
