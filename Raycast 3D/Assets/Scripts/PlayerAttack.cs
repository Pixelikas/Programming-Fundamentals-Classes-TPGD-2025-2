using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
   
    // Create variable to ray distance
    float rayDistance = 20f;

    // Create variable to hit response
    bool hitResponse;

    void Update()
    {

        // Create Vector3 to ray origin position
        Vector3 rayOrigin = transform.position;

        // Create Vector3 to ray direction
        Vector3 rayDirection = Vector3.forward;

        // Create variable to ray hit response
        hitResponse = Physics.Raycast(rayOrigin, rayDirection, out RaycastHit hit, rayDistance);

        // Check if there's a collision  
        if(hitResponse){

            // Show a console message with the object name (collision)
            Debug.Log("Bateu " + hit.collider.name + "! :D");

            // Draw a green ray from player to ray distance 
            Debug.DrawRay(rayOrigin, rayDirection * rayDistance, Color.green);

        }else{

            // Draw a red ray from player to ray distance  
            Debug.DrawRay(rayOrigin, rayDirection * rayDistance, Color.red);

        }

    }
    
}
