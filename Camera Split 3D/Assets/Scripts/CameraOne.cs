using UnityEngine;

public class CameraOne : MonoBehaviour
{

    public Camera cameraPlayerOne;
    public Transform target;
    public Vector3 offset;

    void Start()
    {
        
        cameraPlayerOne.rect = new Rect(0, 0.5f, 1, 0.5f);

    }

    void LateUpdate()
    {
        transform.position = target.position + offset;
        transform.LookAt(target);
    }

}
