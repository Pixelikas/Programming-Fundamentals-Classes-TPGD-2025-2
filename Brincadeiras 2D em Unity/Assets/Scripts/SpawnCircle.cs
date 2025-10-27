using UnityEngine;
using TMPro;

public class SpawnCircle : MonoBehaviour
{

    // Variável para armazenar a referência da bolinha que é spawnada (prefab)
    public GameObject refPrefabCircle;

    // Variável para armazenar a referência do spawnpoint e acessar sua posição
    public Transform refSpawnpoint;

    // Variável para contagem de pontos do score
    // Foi criada como estática para poder ser acessada do outro script
    public static int scorePoints = 0;

    // Variável para armazenar a referência do texto de score
    public TextMeshProUGUI textScore;

    void Update()
    {

        // Verifica se a tecla "X" foi pressionada 
        if (Input.GetKeyDown(KeyCode.X))
        {

            // Chama o método que spawna bolinha com delay (atraso) de 3 segundos
            // Invoke("SpawnBall", 3f);

            // Chama o método que spawna bolinha com delay (atraso) de 2s e a cada 5s
            InvokeRepeating("SpawnBall", 2f, 5f);

        }

        // Atualiza o valor da variável de score no texto
        textScore.text = scorePoints.ToString();

    }

    // Método de spawn da bolinha
    void SpawnBall()
    {

        // Spawna a bolinha na posição e rotação do spawnpoint
        Instantiate(refPrefabCircle, refSpawnpoint.position, refSpawnpoint.rotation);
        
    }

}
