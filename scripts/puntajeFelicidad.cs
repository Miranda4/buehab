using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeFelicidad : MonoBehaviour
{
    private int puntosFelicidad;
    private TextMeshProUGUI tmFelicidad;

    private static controlarPuntos controlarPuntos;

    private void Start()
    {
        tmFelicidad = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        
    }

    public void SumarPuntosFelicidad(int puntosObtenidos)
    {
        puntosFelicidad += puntosObtenidos;
    }
}
