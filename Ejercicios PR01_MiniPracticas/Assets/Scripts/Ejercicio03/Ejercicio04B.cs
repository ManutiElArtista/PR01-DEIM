using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio04B : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Condicional(3, 7));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool Condicional(int num01, int num02)
    {
        int sumatorio = num01 + num02;
        bool aceptar;

        if(sumatorio == 10)
        {
            aceptar = true;
            return aceptar;
        }
        else
        {
            aceptar = false;
            return aceptar;
        }
    }
}
