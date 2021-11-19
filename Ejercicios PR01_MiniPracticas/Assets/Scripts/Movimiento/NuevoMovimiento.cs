using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevoMovimiento : MonoBehaviour
{
    Vector3 initPos = new Vector3(0f, 0f, 0f);
    [SerializeField] float speed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = initPos; // Posicionamos el objeto en la posición que hemos dicho en la variable initPos.
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    void Movimiento ()
    {
        float desplV = Input.GetAxis("Vertical");
        float desplH = Input.GetAxis("Horizontal");
        float desplP = Input.GetAxis("Profundidad");

        transform.Translate(Vector3.right * Time.deltaTime * speed * desplH);
        transform.Translate(Vector3.up * Time.deltaTime * speed * desplV);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * desplP);


    }
}
