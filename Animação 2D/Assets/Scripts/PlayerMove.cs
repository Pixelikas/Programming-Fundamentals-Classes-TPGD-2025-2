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

    private void OnEnable(){

        controlesJogador.Enable();

    }

    private void OnDisable(){

        controlesJogador.Disable();

    }

    void Update()
    {

        direcaoMovimento = controlesJogador.ReadValue<Vector2>();
        fisicaJogador.linearVelocity = new Vector2(direcaoMovimento.x * velocidadeJogador, fisicaJogador.linearVelocity.y);

        if (direcaoMovimento.x != 0)
        {

            estaAndando = true;
            animatorBear.SetBool("isWalking", true);

        }
        else
        {

            estaAndando = false;
            animatorBear.SetBool("isWalking", false);
            
        }

    }

}
