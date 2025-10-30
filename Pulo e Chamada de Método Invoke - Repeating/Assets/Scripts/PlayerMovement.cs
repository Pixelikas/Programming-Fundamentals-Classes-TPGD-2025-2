using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D fisicaPlayer;
    private float velocidadePlayer = 5f;

    private float alturaPuloPlayer = 15f;
    private float inputHorizontal;
    public bool estaPulando = false;


    void Start()
    {

        fisicaPlayer = GetComponent<Rigidbody2D>();

    }

    void Update()
    {

        inputHorizontal = Input.GetAxis("Horizontal");
        fisicaPlayer.linearVelocity = new Vector2(inputHorizontal * velocidadePlayer, fisicaPlayer.linearVelocity.y);

        if (Input.GetButtonDown("Jump") && !estaPulando)
        {

            fisicaPlayer.linearVelocity = new Vector2(fisicaPlayer.linearVelocity.x, alturaPuloPlayer);
            estaPulando = true;

        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {

        estaPulando = false;

    }
    
}
