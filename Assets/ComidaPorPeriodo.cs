using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaPorPeriodo : MonoBehaviour
{
    string G;
    string PP;
    string PG;
    float comidapordia;
    float preciodelalimento;
    float comidatotal;
    public string categoria;
    public int dias;
    // Start is called before the first frame update
    void Start()
    {
         if (categoria==G && dias>=3)
        {
            comidapordia = 300;
            comidatotal = comidapordia * dias;
            preciodelalimento = (comidatotal / 100) * 80;
            Debug.Log("Para ese periodo se necesitan " + comidatotal + " gramos en alimento");
            Debug.Log(" El costo de la cantidad de alimento calculada es de " + preciodelalimento + " pesos");
        }
         else if (categoria==PP && dias>=3)
        {
            comidapordia = 400;
            comidatotal = comidapordia * dias;
            preciodelalimento = (comidatotal / 100) * 80;
            Debug.Log("Para ese periodo se necesitan " + comidatotal + " gramos en alimento");
            Debug.Log("El costo de la cantidad de alimento calculada es de " + preciodelalimento + " pesos");
        }
         else if (categoria==PG && dias>=3)
        {
            comidapordia = 700;
            comidatotal = comidapordia * dias;
            preciodelalimento = (comidatotal / 100) * 80;
            Debug.Log("Para ese periodo se necesitan " + comidatotal + " gramos en alimento");
            Debug.Log("El costo de la cantidad de alimento calculada es de " + preciodelalimento + " pesos");
        }
        
        else
        {
            Debug.Log("Error");

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
