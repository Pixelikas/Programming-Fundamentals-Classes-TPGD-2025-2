using UnityEngine;

public class CameraTwo : MonoBehaviour
{
 
    public Camera cameraPlayerTwo;
    public Transform target;
    public Vector3 offset;

    void Start()
    {

        cameraPlayerTwo.rect = new Rect(0, 0, 1, 0.5f);
        
    }

    void LateUpdate()
    {
        transform.position = target.position + offset;
        transform.LookAt(target);
    }
  
}
