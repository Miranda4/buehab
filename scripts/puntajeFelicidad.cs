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
        tmFelicidad.text = "Felicidad: " + controlarPuntos.cantidadPuntosFelicidad.ToString("0") + "%";
    }

    public void SumarPuntosFelicidad(int puntosObtenidos)
    {
        puntosFelicidad += puntosObtenidos;
    }
}
