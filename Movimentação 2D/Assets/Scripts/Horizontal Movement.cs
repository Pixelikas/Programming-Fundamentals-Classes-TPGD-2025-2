using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{

    private float horizontalInput;
    public float movementSpeed = 5f;
    private Rigidbody2D physicsPlayer;
    private SpriteRenderer spritePlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        physicsPlayer = GetComponent<Rigidbody2D>();
        spritePlayer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        physicsPlayer.linearVelocity = new Vector2(horizontalInput * movementSpeed, physicsPlayer.linearVelocity.y);

        if (horizontalInput > 0){

            spritePlayer.flipX = false;

        }else{

            spritePlayer.flipX = true; 
            
        }

    }
}
