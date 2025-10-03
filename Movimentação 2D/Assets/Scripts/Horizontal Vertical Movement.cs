using UnityEngine;

public class HorizontalVerticalMovement : MonoBehaviour
{

    private float horizontalInput;
    private float verticalInput;
    public float movementSpeed = 5f;
    private Rigidbody2D physicsPlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        physicsPlayer = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        physicsPlayer.linearVelocity = new Vector2(horizontalInput * movementSpeed, verticalInput * movementSpeed);
        
    }
}
