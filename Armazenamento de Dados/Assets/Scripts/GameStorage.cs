using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStorage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int stageNumber = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("StageSaved", stageNumber);
        PlayerPrefs.Save();
        Debug.Log(stageNumber);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
