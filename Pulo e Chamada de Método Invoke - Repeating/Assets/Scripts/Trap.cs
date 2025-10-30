using UnityEngine;

public class Trap : MonoBehaviour
{

    public Transform spawnPoint;
    public GameObject prefabTrap;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Invoke("SpawnTrap", 5f);
        InvokeRepeating("SpawnTrap", 3f, 2f);


    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnTrap()
    {

        Instantiate(prefabTrap, spawnPoint.position, spawnPoint.rotation);

    }

}
