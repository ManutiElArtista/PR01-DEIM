using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reloj1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine("Relojito"); // LLamamos a la corrutina, siempre entre comillas el nombre de la misma.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("E"))
        {
            StartCoroutine("Relojito");
        }
        else if (Input.GetKeyDown("E"))
        {
            StopCoroutine("Relojito");
        }
    }

    IEnumerator Relojito()
    {
        int min = 00;
        int hour = 00;
        
        for(int seg = 01;  ; seg++) // Creamos un bucle infinito con for sin el condicional del centro para que sea infinito.
        {
            if (seg <= 59)
            {
                print(hour + ":" + min + ":" + seg);
            }

            else if(min <= 59 && seg > 59)
            {
                min++;
                seg = 0;
                print(hour + ":" + min + ":" + seg);
                
            }

            else if(min > 59 && seg > 59)
            {
                hour++;
                min = 0;
                seg = 0;
                print(hour + ";" + min + ":" + seg);
                
            }

            else
            {
                StopCoroutine("Relojito"); // Por si hay algun fallo le decimos que si ninguna de las anteriores condiciones se cumplen, que me pare la corrutina, entre parentesis la corrutina.
                print("Corrutina Parada");
            }

            yield return new WaitForSeconds(1f);

        }
    }
}
