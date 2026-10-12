using UnityEngine;

public class Sesion5 : MonoBehaviour
{
    void Start()
    {

        //Ejercicio bucles
        int n = 4;
        string a = "+";
        string tabla = "";

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                a+= "+";
            }
            a += "\n";
        }
        Debug.Log(a);

        for(int i = 0; i < n;i++)
        {
            if (i == 6)
            {
                tabla += "";
                for(int j = 0;j < n; j++)
                {
                    tabla += j + i + "";
                }
            }
            else
            {
                tabla += i * (j + 1) + "";
            }
        }

         //Ejercicio bucles for 
        // Ejercicio 1
        int n = 4;
        int m = 0;
        int resultado = 0;
        int pares = 15;

        for(int i = 1; i < n; i++)
        {
            resultado += i;
        }
        Debug.Log(resultado);

        // Ejercicio 2

        for(int i = 5; i > m; i--)
        {
            Debug.Log(i);
        }
        Debug.Log("Explosión");

        // Ejercicio 3

        for(int i = 1; i <= pares ; i++)
        {
            if (i % 2 == 0)
            {
               Debug.Log (i);
            }
        }


    }

    void Update()
    {
        
    }
}
