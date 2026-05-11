using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameLoad : MonoBehaviour
{

    public SpriteRenderer[] stageSquares;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        StartCoroutine("LoadGame");

    }

    IEnumerator LoadGame()
    {
        
        int stageLoad = PlayerPrefs.GetInt("StageSaved");
        stageSquares[stageLoad-1].color = Color.red;

        yield return new WaitForSeconds(5f);
        Debug.Log(stageLoad);
        SceneManager.LoadScene(stageLoad);

    }

}
