using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactividad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Space)) // Si se pulsa barra espaciadora.
        {
            print("Se pulsa barra espaciadora");
        }
        if(Input.GetMouseButtonDown(0)) // Si se pulsa el boton izquierdo de raton
        {
            print("Se pulsa el izquierdo de boton");
        }
        if(Input.GetButtonDown("Fire1")) // Si se pulsa cntrl left o el boton que tengas asiciado en input manager dxce unity.
        {
            print("Te has agachado");
        }
        if(Input.GetKey("space")) // Si dejas pulsado barra espaciadora, se cumple la condicion.
        {
            print("Se esta disparando");*/

        float desplY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * desplY * Time.deltaTime);
    }
}
