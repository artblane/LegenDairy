using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class asteroid : MonoBehaviour{
public GameObject prefab;

    void PlaceRandomly(GameObject obj)
    {
        if (obj == null) return;

        // Random position for both X and Z axis
        float x = Random.Range(-500f,500f);
        float z = Random.Range(-500f,2000f);
        Vector3 randomPosition = new Vector3(x, 75, z);
        
        //Random Scale
        float xScale = Random.Range(150.0f,3100.0f);
        float zScale = Random.Range(150.0f,3100.0f);
        float yScale = Random.Range(150.0f,3100.0f);
        Vector3 randomScale = new Vector3(xScale,zScale,yScale);
        

        // Set the new position and scale of the object
        obj.transform.position = randomPosition;
        obj.transform.localScale = randomScale;
    }
// for loop to instantiate several random orienations of the asteroid
    void Start () { 
    for(int i = 0; i < 300; ++i)
{
    float xQuat = Random.Range(0.0f,1.0f);
        float yQuat = Random.Range(0.0f,1.0f);
        float zQuat = Random.Range(0.0f,1.0f);
        Quaternion newQuaternion = new Quaternion();
        newQuaternion.Set(xQuat, yQuat, yQuat, zQuat);
        //Return the new Quaternion
        
    
    PlaceRandomly(Instantiate(prefab, new Vector3(0,200, 0), newQuaternion));

    
}
    
    }
   
 
   
    void Update ()
    {
    
    } 

    }

   

    

