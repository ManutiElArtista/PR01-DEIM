using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParImpar : MonoBehaviour
{

    public int vidas;
    // Start is called before the first frame update
    void Start()
    {
        if(Espar(vidas) == true)
        {
            print("Es par");
        }
        else
        {
            print("Es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool Espar(int numero)
    {
        bool esNumeroPar = true;

        if(numero % 2 == 0)
        {
            esNumeroPar = true;
        }
        else if (numero % 2 != 0)
        {
            esNumeroPar = false;
        }

        return esNumeroPar;

    }
}
