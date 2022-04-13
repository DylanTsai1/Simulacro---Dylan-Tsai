using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    public float pesos;
    public string monedaextranjera;
    float convertir;
    // Start is called before the first frame update
    void Start()
    {
        if (pesos>=1000)
        {
            if (monedaextranjera=="D")
            {
                convertir = pesos/200;
                Debug.Log("El monto que ha ingresado es convertido en " + convertir + " dólares");
            }
            else if (monedaextranjera == "R")
            {
                convertir = pesos/25;
                Debug.Log("El monto que ha ingresado es convertido en " + convertir + " reales");
            }
            else if (monedaextranjera == "E")
            {
                convertir = pesos / 220;
                Debug.Log("El monto que ha ingresado es convertido en " + convertir + " euros");
            }
            else
            {
                Debug.Log("Opción de moneda extranjera no válida");
            }
        }

        else
        {
            Debug.Log("El monton minimo es de $1000");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
