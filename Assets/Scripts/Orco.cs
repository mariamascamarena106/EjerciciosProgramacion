using UnityEngine;
using UnityEngine.Video;

public class Orco : MonoBehaviour
{


    //Daño pueda ser mitigado por resistencia *1.5; reducur vida; muestre mensaje del daño recibido y la vida q queda

    public string name;
    public float vida;
    public float resistencia;
    public float fuerza;
    public float destreza;

    
    public Orco(string name, float fuerza,  float destreza, float vida, float resistencia)
    {
        name = "n";
        fuerza = 5.0f;
        resistencia = 10.0f;
        destreza = 8.0f;
        vida = 100 + resistencia * 5;
    }

    float defensa (float dañoEntrante)
    {
        float dañoRecibido = 0;

        vida -= dañoRecibido;

        if(vida < 0)
        {
            vida = 0;
        }
    }
}
