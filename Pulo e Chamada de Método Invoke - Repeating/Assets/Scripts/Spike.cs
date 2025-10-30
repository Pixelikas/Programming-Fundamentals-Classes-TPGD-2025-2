using UnityEngine;

public class Spike : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(gameObject);

        }

         if (collision.gameObject.CompareTag("Death"))
        {

            Destroy(gameObject);

        }

    }



}
