using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    [SerializeField] Transform player;
    [SerializeField] GameObject playerObject; // Creamos una variable de tipo objeto para indicarle que vamos a asociar un objeto a esta variable.

    // [SerializeField] Transform player; // Se pone en mayuscula cuando es un tipo de variable.
    // [SerializeField] GameObject playerObject; // Creamos una variable GameObject.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player); // Le decimos que el transform sea a la variable player.
        // print(playerObject.transform.position); // Diga cual es la posicion del objeto.
        // transform.position(playerObject);

        float newX = playerObject.transform.position.x; // Creamos una variable diciendo que coja del objeto que hemos asociado a ese gameObject, del transform, la posicion de la X.
        float newY = playerObject.transform.position.y; 
        float newZ = transform.position.z; // El valor Z dejamos que sea el mismo que el del objeto que tiene el script.

        transform.position = new Vector3(newX,newY,newZ);

    }
}

