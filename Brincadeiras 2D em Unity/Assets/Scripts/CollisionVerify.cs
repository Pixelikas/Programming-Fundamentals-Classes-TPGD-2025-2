using UnityEngine;

public class CollisionVerify : MonoBehaviour
{
    // // Método para verificar quando uma colisão se mantém "Stay" (poderia ser "Enter")
    void OnTriggerStay2D(Collider2D colisorBolinha)
    {

        // Verifica se o colisor que bateu na bolinha é do objeto com a tag "Destroyer"
        if (colisorBolinha.CompareTag("Destroyer"))
        {

            // Manda mensagem no console com os pontos aumentando enquanto estiver colidindo
            Debug.Log(SpawnCircle.scorePoints++);

        }

    }

    // Método para verificar quando uma colisão se sai "Exit"
    void OnTriggerExit2D(Collider2D colisorBolinha)
    {

        // Verifica se o colisor que bateu na bolinha é do objeto com a tag "Destroyer"
        if (colisorBolinha.CompareTag("Destroyer"))
        {

            // Destrói a bolinha quando sai do colisor
            Destroy(gameObject);

        }

    }

}
