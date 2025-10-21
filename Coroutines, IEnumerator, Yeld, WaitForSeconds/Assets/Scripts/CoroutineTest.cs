using UnityEngine;
using System.Collections;
using TMPro;

public class CoroutineTest : MonoBehaviour
{

    public int contador = 0;
    private SpriteRenderer renderer;
    public GameObject textin;
    private Coroutine minhaCoroutine;

    void Start()
    {

        renderer = GetComponent<SpriteRenderer>();
        minhaCoroutine = StartCoroutine(DestroyPlayer());
        
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.X)){

            StopCoroutine(minhaCoroutine);
            Debug.Log("Coroutine stops! :D");

        }
        
    }

    IEnumerator DestroyPlayer(){
        
        // yield return new WaitUntil(() => renderer.flipX == true);
        yield return new WaitUntil(() => renderer.color == Color.red);
        // yield return new WaitUntil(() => contador == 10); 
        // yield return new WaitForSeconds(2f);
        textin.SetActive(true);
        // Destroy(gameObject);

        // while(true){

        //     contador++;
        //     Debug.Log(contador);
        //     yield return null;

        // }
        

    }

    void OnMouseDown(){

        // contador++;
        // StopCoroutine(minhaCoroutine);

    }

}
