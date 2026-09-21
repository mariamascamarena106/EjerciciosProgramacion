using UnityEngine;

public class Sesion1 : MonoBehaviour
{
    void Start()
    {

        //Variables 1
        Debug.Log("Iniciando el curso");
        Debug.Log(20394 + 103931);
        Debug.Log(130 * 340);
        Debug.Log(10.5 / 4.0);

        //Variables 2

        int variable1 = 10;
        int variable2 = 2;
        float factor = 2500f;
        float metros = 1609f;
        float milla = factor / metros;

        Debug.Log(variable1 * variable2);
        Debug.Log(variable1 /  variable2);
        Debug.Log(variable1 % variable2);
        Debug.Log(milla);

        //Variables 3

        int t0 = 1;
        int t1 = 2;
        float vel = 5f;
        float d = vel * (t1 - t0);
        Debug.Log(d);

        //Variables 4

        int segundos = 143;
        int minutos = (segundos / 60) & (segundos % 60);
        Debug.Log(minutos);

    }

    void Update()
    {
        
    }
}
