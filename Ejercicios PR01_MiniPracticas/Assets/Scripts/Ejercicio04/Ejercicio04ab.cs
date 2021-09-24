using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio04ab : MonoBehaviour
{

    bool contUp = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (contUp == false)
            {
                StartCoroutine("Contador");
                contUp = true;
            }
            else
            {
                StopCoroutine("Contador");
                contUp = false;
            }
        }
        
    }

    IEnumerator Contador()
    {
        for (int num01 = 1; ; num01++)
        {
            Debug.Log(num01);
            yield return new WaitForSeconds(1f);
        }
    }
}
