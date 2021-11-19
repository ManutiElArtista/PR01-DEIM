using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float desplV = Input.GetAxis("Vertical"); // Coja el eje vertical.
        transform.Translate(Vector3.up * Time.deltaTime * speed * desplV); // Que cambie el transform hacia arriba y lo mueva cuando se pulsen las teclas asignadas.

        float desplH = Input.GetAxis("Horizontal"); // Coja el eje horizontal.
        transform.Translate(Vector3.right * Time.deltaTime * speed * desplH); // Que cambie el transform hacia laterales y lo mueva cuando se pulsen las teclas asignadas.

        float desplP = Input.GetAxis("Profundidad"); // Coja el eje profundidad creado anteriormente.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * desplP); // Que cambie el transform hacia detras y delante cuando se pulsen las teclas asignadas.

        print(Input.GetAxis("Horizontal")); // Muestra la posicion del boton que pulsas, up o down en este caso.
        print(Input.GetAxis("Vertical"));
        print(Input.GetAxis("Profundidad"));

    }
}
