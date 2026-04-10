using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody2D fisicaJogador;
    public float velocidadeJogador = 5f;

    public InputAction controlesJogador;
    Vector2 direcaoMovimento;

    public TextMeshProUGUI textoPontos;
    public int pontosJogador = 0;

    public InputAction addPontos;


    private void OnEnable(){

        controlesJogador.Enable();
        addPontos.Enable();
        addPontos.performed += AddPoints;

    }

    private void OnDisable(){

        controlesJogador.Disable();
        addPontos.Disable();

    }

    void Update()
    {

        direcaoMovimento = controlesJogador.ReadValue<Vector2>();
        fisicaJogador.linearVelocity = new Vector2(direcaoMovimento.x * velocidadeJogador, direcaoMovimento.y * velocidadeJogador);

    }

    void AddPoints(InputAction.CallbackContext context){

        pontosJogador++;
        textoPontos.text = pontosJogador.ToString();

    }

}
