using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playerSpeed = 10f;
    public float playerJump = 5f;
    private Rigidbody playerPhysics;

    void Start(){
        playerPhysics = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        //                                         X         Y        Z
        Vector3 playerMovement = new Vector3(horizontalMove, 0, verticalMove);
        //                       Vector3        Speed       Game Time FPS
        transform.Translate(playerMovement * playerSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerPhysics.AddForce(Vector3.up * playerJump, ForceMode.Impulse);

        }
    }
}
