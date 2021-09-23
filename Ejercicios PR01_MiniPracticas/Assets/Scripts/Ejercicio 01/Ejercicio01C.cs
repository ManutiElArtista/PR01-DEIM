using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio01C : MonoBehaviour
{
    public int num = 10;
    private int num1 = 30;
    public float dec = 19f;
    public bool file = false;
    public string word = "Hola";

    // Start is called before the first frame update
    void Start()
    {
        print(num);
        print(dec);
        print(file);
        print(word);
        print(num + num1);
        print(num - num1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
