using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class FOR : MonoBehaviour
{

    //public List<string> nomes = new List<string> {"Lucas", "Abgail", "Astrogildo"};
    public string[] bubbles = {"Olá, tudo bem?", "Eu me chamo Oika", "Quer ser meu amigo?"};
    public TextMeshProUGUI texto;
    public Transform[] spawnpoints;
    public GameObject prefabBola;
    private int indexItems = 0;
    public Sprite[] items;
    private SpriteRenderer spritePlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        spritePlayer = GetComponent<SpriteRenderer>();

        for(int i=0; i < spawnpoints.Length; i++){

            Instantiate(prefabBola, spawnpoints[i]);

        }
     
    }

    // Update is called once per frame
    void Update()
    {

        TrocaItem();

        if(Input.GetKeyDown(KeyCode.X)){

            indexItems++;

        }

        if(Input.GetKeyDown(KeyCode.Z)){

            indexItems--;

        }
        
    }

    // void MostraDialogos(){

    //     texto.text = bubbles[i];

    // }

    void TrocaItem(){

        spritePlayer.sprite = items[indexItems];

    }
}
