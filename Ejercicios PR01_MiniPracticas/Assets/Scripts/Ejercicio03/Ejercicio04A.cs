using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio04A : MonoBehaviour
{
    public string name01 = "Willy";
    // Start is called before the first frame update
    void Start()
    {
        Saludo(name01);

        /*print(Nombre() + name01);*/ // Ya estas llamando al metodo directamente al ponerlo en el print.
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void Saludo(string nombre)
    {
        print("Hola " + nombre);
    }

    /*string Nombre()
    {
        string saludo = "Hola ";
        return saludo;
    }*/
}
