using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piramide : MonoBehaviour
{
    public string cadenaDeAsteriscos = "*";
    public int numeroDeLineas = 5;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numeroDeLineas; i++){
            Debug.Log(cadenaDeAsteriscos);
            cadenaDeAsteriscos = cadenaDeAsteriscos + "*";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
