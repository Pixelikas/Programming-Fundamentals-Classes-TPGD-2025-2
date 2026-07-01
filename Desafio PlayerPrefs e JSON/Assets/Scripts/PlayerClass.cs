using UnityEngine;

public class Inimigo
{
    public string nomeInimigo;
    public float velocidadeInimigo;
    public string armaInimigo;
    public int vidaInimigo;
    public int ataqueInimigo;


    public Inimigo(string nome, float velocidade, string arma, int vida, int ataque)
    {
        this.nomeInimigo = nomeInimigo;
        this.velocidadeInimigo = velocidade;
        this.armaInimigo = armaInimigo;
        this.vidaInimigo = vidaInimigo;
        this.ataqueInimigo = ataqueInimigo;
    }

    Inimigo InimigoUm = new Inimigo("Azcak", 3.5f, "Shotgun", 50, 10);
    InimigoUm.Atacar();


    public void Atacar()
    {
        Debug.Log(nomeInimigo + " atacou!");
    }
}

