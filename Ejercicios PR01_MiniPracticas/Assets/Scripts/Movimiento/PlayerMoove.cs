using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoove : MonoBehaviour
{

    private Vector3 cubePos = new Vector3(0, 0, 0); // Creamos una variable de tipo Vector3 que dentro tenga un nuevo vector3 con los valores que queramos.
    public float speed; // Creamos una variable llamada speed que la vamos a pasar para darle velocidad al movimiento.

    // Start is called before the first frame update
    void Start()
    {
        // transform.position = cubePos; //Sirve para posicionar el objeto en la posicion indicada.
    }

    // Update is called once per frame
    void Update()
    {
        // print(transform.position.x); // Sirve para mostrar en consola la posicion del objeto que tenga el script asociado del menu transform, la posicion del eje X.

        Vector3 destPos = new Vector3(0f, 0f, 0f); // Creamos una nueva variable indicando hacia donde queremos que se mueva para sumarla al original.
        cubePos = cubePos + destPos * Time.deltaTime * speed; // Le decimos que la variable cubePos, sea la suma de los 2 vectores, el inicial, mas el que hemos creado. 
                                                              // El delta time te regula los frames dependiendo de la potencia de tu ordenador.
                                                              // El speed es la velocidad a la que se va a mover el objeto.
        transform.position = cubePos; // Le estamos indicando que la posicion sea la suma de las dos anteriores.
    }
}
