using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
 
    public void StartButton()
    {

        // Carrega a cena de mapa do jogo
        SceneManager.LoadScene(4);

    }
   
}
