using UnityEngine;

public class ObjectRotate : MonoBehaviour
{

    // Update is called once per frame
    public GameObject prefab;
    public Transform spawnPoint;
    public float speed = 10f;

    void Update()
    {

        LookAtAim();
        SpawnBullet();

    }

    void LookAtAim()
    {

        // Posição do mouse em coordenadas de mundo
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Direção do objeto até o mouse
        Vector2 direction = mousePosition - transform.position;

        // Calcula o ângulo (em radianos) e converte para graus
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Aplica a rotação apenas no eixo Z (2D)
        transform.rotation = Quaternion.Euler(0f, 0f, angle);

    }

    void SpawnBullet()
    {

        if (Input.GetMouseButtonDown(0)) // Clique com o botão esquerdo
        {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos.z = 0f;

            // Instancia na posição do objeto atual (ou onde quiser)
            GameObject instance = Instantiate(prefab, spawnPoint.position, Quaternion.identity);

            // Calcula a direção normalizada
            Vector2 direction = (mouseWorldPos - transform.position).normalized;

            // Passa a direção e velocidade para o objeto instanciado
            instance.GetComponent<BulletPrefab>().Initialize(direction, speed);
        }

    }
    
}
