using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadDataScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        string loadData = PlayerPrefs.GetString("PlayerSavedData");
        PlayerClass playerObject = new PlayerClass();
        playerObject = JsonUtility.FromJson<PlayerClass>(loadData);

        UIManager.coinsCount = playerObject.coinsPlayer;
        UIManager.scoreCount = playerObject.scorePlayer;
        
    }

}
