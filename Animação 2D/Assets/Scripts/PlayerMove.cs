using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody2D fisicaJogador;
    public float velocidadeJogador = 5f;

    public InputAction controlesJogador;
    Vector2 direcaoMovimento;

    public bool estaAndando = false;
    public Animator animatorBear;

    public InputAction puloJogador;
    private float alturaPuloJogador = 15f;
    public bool estaNoChao = true;

    public SpriteRenderer spriteJogador;

    private void OnEnable(){

        controlesJogador.Enable();
        puloJogador.Enable();
        puloJogador.performed += Pular;

    }

    private void OnDisable(){

        controlesJogador.Disable();
        puloJogador.Disable();

    }

    void Update()
    {

        direcaoMovimento = controlesJogador.ReadValue<Vector2>();
        fisicaJogador.linearVelocity = new Vector2(direcaoMovimento.x * velocidadeJogador, fisicaJogador.linearVelocity.y);

        if (direcaoMovimento.x > 0)
        {

            estaAndando = true;
            animatorBear.SetBool("isWalking", true);
            spriteJogador.flipX = false;

        }
        else if(direcaoMovimento.x < 0)
        {

            estaAndando = true;
            animatorBear.SetBool("isWalking", true);
            spriteJogador.flipX = true;
            
            
        }else{

            estaAndando = false;
            animatorBear.SetBool("isWalking", false);

        }

    }

    void Pular(InputAction.CallbackContext context){

        if(estaNoChao){

            fisicaJogador.linearVelocity = new Vector2(fisicaJogador.linearVelocity.x, alturaPuloJogador);
            estaNoChao = false;

        }

    }

    void OnCollisionEnter2D(Collision2D col){

        estaNoChao = true;

    }

}
