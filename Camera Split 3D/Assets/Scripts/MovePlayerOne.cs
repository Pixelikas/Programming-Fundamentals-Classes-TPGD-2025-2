using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayerOne : MonoBehaviour
{
    
    public Rigidbody playerOneRigidbody;
    public InputAction playerOneController;
    public float playerOneSpeed = 5f;
    Vector3 playerOneDirection; 

    void Start()
    {
        
        playerOneRigidbody = GetComponent<Rigidbody>();

    }

    private void OnEnable()
    {
        playerOneController.Enable();
    }

    private void OnDisable()
    {
        playerOneController.Disable();
    }

    // Update is called once per frame
    void Update()
    {

        playerOneDirection = playerOneController.ReadValue<Vector3>();
        transform.Translate(playerOneDirection * playerOneSpeed * Time.deltaTime);
        
    }
}
