using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayerTwo : MonoBehaviour
{
    public Rigidbody playerTwoRigidbody;
    public InputAction playerTwoController;
    public float playerTwoSpeed = 5f;
    Vector3 playerTwoDirection; 

    void Start()
    {
        
        playerTwoRigidbody = GetComponent<Rigidbody>();

    }

    private void OnEnable()
    {
        playerTwoController.Enable();
    }

    private void OnDisable()
    {
        playerTwoController.Disable();
    }

    // Update is called once per frame
    void Update()
    {

        playerTwoDirection = playerTwoController.ReadValue<Vector3>();
        transform.Translate(playerTwoDirection * playerTwoSpeed * Time.deltaTime);
        
    }
}
