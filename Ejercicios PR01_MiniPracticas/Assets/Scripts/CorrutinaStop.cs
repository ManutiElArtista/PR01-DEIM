using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrutinaStop : MonoBehaviour
{

    public int valor = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InicioCorrutina(valor));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator InicioCorrutina(int num)
    {
        for (int cont = 1; cont <= num ;cont++)
        {

            print(cont);
            yield return new WaitForSeconds(1f); //Indicamos cada cuanto tiempo se reinicia la corrutina.

            if (cont > num) // Le decimos que si se da esta condicion, pare la corrutina.
            {
                StopCoroutine("InicioCorrutina"); // El valor del stop corrutine va entre comillas.
            }
        }
    }
}
