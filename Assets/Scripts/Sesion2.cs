using UnityEngine;

public class Sesion2 : MonoBehaviour
{
    void Start()
    {
        //Ejercicio 1
        float x = 2f;
        float resultado = 10f * Mathf.Pow(x, 3) + 5f * Mathf.Pow(x, 2) + 10f * Mathf.Pow(x, 1) + 5f;

        Debug.Log(resultado);

        //Ejercicio 2

        int añoActual = 2026;
        int añoNacimiento = 2007;
        int edad = añoActual - añoNacimiento;
        Debug.Log(edad);

        //Ejercicio 3

        bool mayor = edad >= 18;
        bool menor = edad < 18;

        if (mayor)
        {
            Debug.Log("Puedes acceder");
        }

        Debug.Log("++Fin del programa++");

        //Ejercicio 4

        int upperLimitY = 700;
        int loweLimitY = 0;
        int posFlappyY = 50;

        if (posFlappyY > upperLimitY || posFlappyY < loweLimitY)
        {
            Debug.Log("Está fuera");
        }

        //Ejercicio 5

        int dia = 1;

        if(dia == 1)
        {
            Debug.Log("Lunes");
        }
        else
        {
            if (dia == 2)
            {
                Debug.Log("Martes");
            }
            else
            {
                if (dia == 3)
                {
                    Debug.Log("Miercoles");
                }
                else
                {
                    if (dia == 4)
                    {
                        Debug.Log("Jueves");
                    }
                    else
                    {
                        if (dia == 5)
                        {
                            Debug.Log("Viernes");
                        }
                    }
                }
            }
        }

        //Ejercicio 6

        int ejeX = 1;
        int ejeY = 1;
        bool X = ejeX > 0;
        bool Y = ejeY > 0;

        if (X && Y)
        {
            Debug.Log("Primer cuadrante");
        }
        else
        {
            if (!X && Y)
            {
                Debug.Log("Segundo cuadrante");
            }
            else
            {
                if (!X && !Y)
                {
                    Debug.Log("Tercer cuadrante");
                }
                else
                {
                    if (X && !Y)
                    {
                        Debug.Log("Cuarto cuadrante");
                    }
                }
            }
        }

        //Ejercicio 7

        bool piedra = true;
        bool papel = true;
        bool tijera = false;

        if (piedra && papel || papel && piedra)
        {
            Debug.Log("Gana papel");
        }
        else
        {
            if (piedra && tijera || tijera && piedra)
            {
                Debug.Log("Gana piedra");
            }
            else
            {
                if (papel && tijera || tijera && papel)
                {
                    Debug.Log("Gana tijera");
                }
                else
                {
                    Debug.Log("Empate");
                }
            }
        }

        //Ejercicio 8

        int ataqueD = 2;
        int ataque = 5;
        bool impacta = ataque >= 4;
        bool defensa = ataqueD >= 5;

        if (impacta)
        {
            Debug.Log(defensa);
        }
        else
        {

        }
    }

    void Update()
    {
        
    }
}
