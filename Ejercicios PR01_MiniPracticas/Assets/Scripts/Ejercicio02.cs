using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio02 : MonoBehaviour
{
    public int num = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        /*int num01;
        num01 = 1;
        while(num01 <= 10)
        {
            print(num01);
            num01++;
        }
        for (int num02 = 1; num02 <= 10; num02++) //for ( variable ; la condicion ; lo que va a realizar).
        {
            print();
        }*/
        int num03;
        num03 = 1;
        while (num03 <=10)
        {
            if (num03 < 5)
            {
                print("Es menor que 5");
            }

            else if (num03 >= 5 && num03 < 10) // Para añadir varias condiciones a un if utilizar && (y) || (o).
            {
                print("Es " + num03);
            }

            else
            {
                print("El numero es 10");
            }
            num03++;
        }
    }

    // Update is called once per frame

    void Update()
    {
        /*if(num < 10)
        {
            print(num);
            num++;
        }
        else
        {
            print(num);
        }*/
    }
}
