using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{
    int aleatorio;

    // Start is called before the first frame update
    void Start()
    {
        /*int cont = 0;
        for(int n = 0; n < 100; n++)
         {
             aleatorio = Random.Range(0, 10);
             if(aleatorio == 7)
             {
                 cont++;
             }
             else
             {
             }
         }
         print("El numero 7 ha salido " + cont);
        */
        int fail = 0;

        while(aleatorio != 499)
        {
            aleatorio = Random.Range(0, 500); //Creamos variable aleatorio, le damos el valor de que Random.Range(valor m�nimo ; valor m�ximo)
            if (aleatorio == 499)
            {
                print("Ha salido el numero " + aleatorio);
                print("Ha llegado " + fail + " numero de veces");
            }
            else
            {
                fail++;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
