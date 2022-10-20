using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeSueno : MonoBehaviour
{
    private int puntosSueno;
    private TextMeshProUGUI tmSueno;

    private static controlarPuntos controlarPuntos;

    private void Start()
    {
        tmSueno = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        tmSueno.text = "Sueño: " + controlarPuntos.cantidadPuntosSueno.ToString("0") + "%";
    }

    public void SumarPuntosSueno(int puntosObtenidos)
    {
        puntosSueno += puntosObtenidos;
    }
}
