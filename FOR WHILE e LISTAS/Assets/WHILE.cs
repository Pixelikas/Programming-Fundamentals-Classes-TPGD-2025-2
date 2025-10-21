using UnityEngine;

public class WHILE : MonoBehaviour
{
    
    bool mostraMensagem = true;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

               
    }

    // Update is called once per frame
    void Update()
    {

        while(mostraMensagem){

            Debug.Log("Bu-Bu-Bu");

        }

        if(Input.GetKeyDown(KeyCode.X)){

            mostraMensagem = false;

        }
        
    }
}
