using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerClick : MonoBehaviour
{

    public void OnMouseDown()
    {
        
        SaveDataJSON();
        Destroy(gameObject);

    }

    public static void SaveDataJSON()
    {
        
        PlayerClass playerObject = new PlayerClass();

        playerObject.stageGame = SceneManager.GetActiveScene().buildIndex;
        playerObject.coinsPlayer = UIManager.coinsCount;
        playerObject.scorePlayer = UIManager.scoreCount;

        string playerDataJSON = JsonUtility.ToJson(playerObject, true);
        Debug.Log("SAVED DATA: " + playerDataJSON);

        PlayerPrefs.SetString("PlayerSavedData", playerDataJSON);
        PlayerPrefs.Save();

    }

}
