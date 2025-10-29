using UnityEngine;

public class RandomNumber : MonoBehaviour
{

    private int intRandomNumber;
    private int minNumber = 0, maxNumber = 3;
    public string [] names = {"Lucas", "Abgail", "Ursula", "Astrogildo"};

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        for(int i=0; i < 2; i++){

            intRandomNumber = Random.Range(minNumber, maxNumber);
            Debug.Log(names[intRandomNumber]);

        }
        
    }
   
}
