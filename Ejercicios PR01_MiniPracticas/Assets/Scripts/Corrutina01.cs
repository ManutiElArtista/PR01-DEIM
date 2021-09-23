using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Corrutina01 : MonoBehaviour
{

    [SerializeField] private int cont;

    // Start is called before the first frame update
    void Start()
    {
     
        
    }

    // Update is called once per frame
    void Update()
    {
        // Poner en el Update la condicion para que refresque a cada frame, si lo ponemos en start no funciona.
        if (Input.GetKeyDown(KeyCode.P))
        {
            StartCoroutine(Control(1f));
        }
        else
        {

        }
    }

    IEnumerator Control(float tiempo)
    {
        for (cont = 10; /*cont >= 0*/; cont--) // Puedes dejar el valor del centro sin valor, asi se crea infinito.
        {
            if (cont <= 0)
            {
                StopCoroutine("Control"); //Poner la corrutina a parar entre comillas, si no, no lo entiende.
                yield return new WaitForSeconds(tiempo);
                Debug.Log(cont);
                Debug.Log("Ha explotado");
            }
            else
            {

            }
        }
        
        /* yield return new WaitForSeconds(tiempo); // Manera para devolver el valor a la corrutina, se le puede poner el valor que sea.
        Debug.Log(tiempo);*/
    }
}
