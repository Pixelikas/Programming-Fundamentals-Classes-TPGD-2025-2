using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI textoInterface;
    private int cliques = 100;
    private int dano = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Debug.Log("Bu!");
        textoInterface.text = cliques.ToString();

    }

    // Update is called once per frame
    void Update()
    {

        // Debug.Log("Bu!");

        if (cliques <= 0){

            // textoInterface.text = "Game Over";
            // gameObject.SetActive(false);
            // Destroy(gameObject);
            // SceneManager.LoadScene(1);
            SceneManager.LoadScene("CenaNova");

        }

        if (Input.GetKeyDown(KeyCode.X))
        {

            // Debug.Log("Apertou X");

        }

        if (Input.GetMouseButtonDown(1))
        {

            // Debug.Log("Apertou Botão Direito Mouse");

        }

    }

    void OnMouseDown()
    {

        // Debug.Log("Clicouuuuuu! :D");
        cliques = cliques - dano;
        textoInterface.text = cliques.ToString();

    }

}
