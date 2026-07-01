using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoad : MonoBehaviour
{
   
    public static void ClickLoad()
    {
        
        string loadData = PlayerPrefs.GetString("PlayerSavedData");
        PlayerClass playerObject = new PlayerClass();
        playerObject = JsonUtility.FromJson<PlayerClass>(loadData);

        SceneManager.LoadScene(playerObject.stageGame);

    }    

}
