using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoverObjetos : MonoBehaviour
{
    private Vector3 initNum = new Vector3(1, 1, 1); // Creamos la variable indicando que es una variable de tipo Vector3, le decimos que es una nueva clase tipo Vector 3 y le damos los valores iniciales.
    private Vector3 verPos; // Vamos a ver que posicion tiene el objeto que tenga el script, creamos la variable Vector3 sin valor.
    [SerializeField] Vector3 sumPos; // Para sumar posiciones, tenemos que tener 2 varibles de tipo vector, este caso una srializeField.
    private Vector3 finalPos; 
    [SerializeField] int Speed = 1; // Creamos una variable que va a indicar la velocidad del objeto.
    [SerializeField] GameObject otherObject;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = initNum; // Le indicamos al método Start, que la posicion de ese objeto, sea el mismo que el valor que hemos puesto en la variable initNum.
        // verPos = transform.position; // le indicamos que la variable verPos es la la que tenga el objeto.
        finalPos = verPos + sumPos * Time.deltaTime * Speed; // Multiplicamos por delta time y por la velocidad para que se mueva.
        // transform.position = finalPos; // Le indicamos que el objeto se mueva segun el valor de finalPos.
        otherObject.transform.position = finalPos; // Le decimos que la posicion final sea la de la esfera.
        initNum = otherObject.transform.position; // Le indicamos que la posicion inicial sea la de la esfera.
    }
}
