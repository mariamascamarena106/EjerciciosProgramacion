using UnityEngine;

public class Sesion4 : MonoBehaviour
{

    void Start()
    {

        //Bucle for
        //Ej 1
        int n = 4;
        for (int i = 0; 0 < n; n--)
        {
            i = i + n;
            Debug.Log(i);
        }

        //Ej 2
        for(int cont = 5; cont > 0; cont--)
        {
            Debug.Log(cont);
        }
        Debug.Log("EXPLOSIÓN");

        //Ej 3
        //for (int par = 0;  par <= 10; par -= 2)
        {
            //Debug.Log(par);
        }


        //Dados

        int caras = 6;
        int nDados = 3;
        int nTiradas = 100;
        int[] tiradas = new int[nDados * caras + 1];
        int sumaResultado = 0;

        for (int i = 0; i < nTiradas; i++)
        {
            
            for (int j = 0; j < nDados; j++)
            {
                sumaResultado += Random.Range(1, caras + 1);
            }
            tiradas[sumaResultado]++;
        }
       for(int i = 1; i < tiradas.Length; i++)
        {
            Debug.Log("Suma:" + i + "Frec:" + tiradas[i]);
        }
       //REVISAR


       //Foreach
       //mirar apuntes



    }

    void Update()
    {
        
    }
}
