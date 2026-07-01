using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI scoreText;
    public static int coinsCount, scoreCount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        coinsText.text = coinsCount.ToString();
        scoreText.text = scoreCount.ToString();
        
    }

    public static void ClickCount()
    {
        
        coinsCount++;
        scoreCount = scoreCount + 15;

    }

}
