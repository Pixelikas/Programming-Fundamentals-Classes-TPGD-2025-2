using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{

    // Create variable to ray distance
    public float rayDistance = 10f;

    void Update()
    {

        // Create Vector2 to ray origin position
        Vector2 rayOrigin = transform.position;
        
        // Create Vector2 to ray direction
        Vector2 rayDirection = Vector2.right; 

        // Create ray and variable to object that will collide
        RaycastHit2D hit = Physics2D.Raycast(rayOrigin, rayDirection rayDistance);
        
        // Check if there's a collision  
        if(hit.collider != null)
        {

            // Draw a green line from player to collision point   
            Debug.DrawLine(rayOrigin, hit.point, Color.green);

            // Show a console message with the object name (collision)
            Debug.Log("Hit with " + hit.collider.name + "! :D");

        }else
        {
            
            // Draw a red ray from player to ray distance  
            Debug.DrawRay(rayOrigin, rayDirection * rayDistance, Color.red);

        }

    }
}
