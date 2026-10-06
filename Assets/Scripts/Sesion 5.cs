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


    }

    void Update()
    {
        
    }
}
