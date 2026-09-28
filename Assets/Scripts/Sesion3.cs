using UnityEngine;

public class Sesion3 : MonoBehaviour
{
    void Start()
    {

        // Act 1
        int fuerza = 0;
        fuerza = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;

        int cons = 0;
        cons = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;

        int des = 0;
        des = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;

        int apa = 0;
        apa = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;

        int pod = 0;
        pod = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;

        int sue = 0;
        sue = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;

        int tam = 0;
        tam = ((Random.Range(1, 7) + Random.Range(1, 7)) + 6) * 5;

        int intel = 0;
        intel = ((Random.Range(1, 7) + Random.Range(1, 7)) + 6) * 5;

        int edu = 0;
        edu = ((Random.Range(1, 7) + Random.Range(1, 7)) + 6) * 5;

        int mov = 0;

        int edad = 55;

        //Act 2

        if (15 <= edad && edad <= 19)
        {
            fuerza -= 5;
            tam -= 5;
            edu -= 5;
        }
        else if (20 <= edad && edad <= 39)
        {
            int UnD100 = Random.Range(1, 101);
            if (UnD100 > edu)
            {
                edu += Random.Range(1, 11);
            }
        }


        //Act 3 

        if(des < tam && fuerza < tam)
        {
            mov += 7;
        }
        else if(des > tam || fuerza > tam)
        {
            mov += 8;
        }
        else if(des > tam && fuerza > tam)
        {
            mov += 9;
        }

        //Act 4

        if (edad >= 40 && edad <= 49)
        {
            mov += -1;
        }
        else if (edad >= 50 && edad <= 59)
        {
            mov += -1;
        }
        else if (edad >= 60 && edad <= 69)
        {
            mov += -3;
        }
        else if (edad >= 70 && edad <= 79)
        {
            mov += -4;
        }
        else if (edad >= 80 && edad <= 89)
        {
            mov += -5;
        }

        //Versión en bucle
        //Ej 1

        int n = 1;
        while (n <= 100)
        {
            Debug.Log(n);
            n++;
        }

        //Ej 2

        int num1 = 4;
        int num2 = 3;
        int result = 0;

        while (num2 <= 3 && num2 > 0)
        {
            result += num1;
            num2--;
        }
        Debug.Log(result);
    }

    void Update()
    {

    }
}
