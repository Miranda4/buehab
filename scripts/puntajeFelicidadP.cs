using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeFelicidadP : MonoBehaviour
{
    private int puntosFelicidadP;
    private TextMeshProUGUI tmFelicidadP;

    private static controlarPuntos controlarPuntos;

    private void Start()
    {
        tmFelicidadP = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        tmFelicidadP.text = "Felicidad: " + controlarPuntos.cantidadPuntosFelicidadP.ToString("0") + "%";
    }

    public void SumarPuntosFelicidadP(int puntosObtenidos)
    {
        puntosFelicidadP += puntosObtenidos;
    }
}
