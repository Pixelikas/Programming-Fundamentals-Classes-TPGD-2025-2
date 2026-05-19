using UnityEngine;

public class PlayerSave : MonoBehaviour
{

    void Start()
    {

        SaveDataJSON();
        
    }

    public static void SaveDataJSON()
    {
        
        PlayerClass playerObject = new PlayerClass();

        playerObject.charName = "Jett";
        playerObject.charAge = 20;
        playerObject.charHeight = 1.78f;
        playerObject.charDash = true; 

        string playerDataJSON = JsonUtility.ToJson(playerObject, true);
        Debug.Log("SAVE DATA: " + playerDataJSON);

        playerObject = JsonUtility.FromJson<PlayerClass>(playerDataJSON);
        Debug.Log("LOAD DATA\n" + "Name: " + playerObject.charName + "\nAge: " + playerObject.charAge);

    }

}
