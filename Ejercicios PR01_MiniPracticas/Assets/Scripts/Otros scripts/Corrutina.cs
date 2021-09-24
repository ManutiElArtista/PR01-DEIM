using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEditor;

public class Corrutina : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Reloj(3f)); // Para iniciar la corrutina hay que llamar a este método
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Reloj(float tiempo)
    {
            //yield return null; // Decir cada cuanto se tiene que repetir, null para que se repita cada fotograma.
            yield return new WaitForSeconds(tiempo); // Puedes indicarle que se repita cada segundo o el numero que quieras.
            Debug.Log("Han pasado " + tiempo + " segundos");
    }
}
