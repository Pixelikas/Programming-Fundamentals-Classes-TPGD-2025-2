using TMPro;
using UnityEngine;

public class Collision : MonoBehaviour
{

    // Cria variável de referência para o TextMeshPro
    public TextMeshProUGUI textoHP;

    // Cria variável de referência para o SpriteRenderer
    public SpriteRenderer spriteStatus;

    // Cria variável de HP para o player
    public int playerHP = 1000;

    // Método para detectar entrada de colisão
    void OnTriggerEnter2D(Collider2D colisor)
    {

        // Verifica se o colisor que entrou é do objeto que tem a tag "Danger" 
        if (colisor.gameObject.CompareTag("Danger"))
        {

            // Troca a cor do sprite Status para vermelho
            spriteStatus.color = Color.red;

        }

    }

    // Método para detectar permanência de colisão
    void OnTriggerStay2D(Collider2D colisor)
    {

        // Verifica se o colisor que entrou é do objeto que tem a tag "Danger" 
        if (colisor.gameObject.CompareTag("Danger"))
        {

            // Diminui a variável de HP
            playerHP--;

            // Mostra o valor da variável de HP no texto TextMeshPro da UI
            textoHP.text = playerHP.ToString();


        }
        
    }   

    // Método para detectar saída de colisão
    void OnTriggerExit2D(Collider2D colisor)
    {

        // Verifica se o colisor que entrou é do objeto que tem a tag "Danger" 
        if (colisor.gameObject.CompareTag("Danger"))
        {


            // Troca a cor do sprite Status para verde
            spriteStatus.color = Color.green;

        }
        
    }

}
