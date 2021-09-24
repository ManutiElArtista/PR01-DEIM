using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio04a : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine("Relojito"); // LLamamos a la corrutina, siempre entre comillas el nombre de la misma.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // Pulsar la E en maysucula para iniciar la corrutina.
        {
            StartCoroutine("Relojito");
        }
        if (Input.GetKeyDown(KeyCode.R)) // Pulsar la R en mayuscula para iniciar la corrutina.
        {
            StopCoroutine("Relojito");
            print("Corrutina Parada");
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
                print(hour.ToString("D2") + ":" + min.ToString("D2") + ":" + seg.ToString("D2")); // variable.ToString("D5"), te muestra 5 digitos totales.
            }

            else if(min <= 59 && seg > 59)
            {
                min++;
                seg = 0;
                print(hour.ToString("D2") + ":" + min.ToString("D2") + ":" + seg.ToString("D2"));

            }

            else if(min > 59 && seg > 59)
            {
                hour++;
                min = 0;
                seg = 0;
                print(hour.ToString("D2") + ":" + min.ToString("D2") + ":" + seg.ToString("D2"));

            }

            else
            {
                /*StopCoroutine("Relojito"); // Por si hay algun fallo le decimos que si ninguna de las anteriores condiciones se cumplen, que me pare la corrutina, entre parentesis la corrutina.
                print("Corrutina Parada");*/
            }

            yield return new WaitForSeconds(1f);

        }
    }
}

// Time.time sirve para coger el tiempo desde que se inició el juego, si se le da a pausa, este valor se para también.