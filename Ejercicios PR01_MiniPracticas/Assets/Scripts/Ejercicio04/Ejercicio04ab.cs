using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio04ab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine("Contador");
        }
        if(Input.GetKeyUp(KeyCode.E))
        {
            StopCoroutine("Contador");
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
