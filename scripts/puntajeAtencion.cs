using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeAtencion : MonoBehaviour
{
    private int puntosAtencion;
    private TextMeshProUGUI tmAtencion;

    private static controlarPuntos controlarPuntos;

    private void Start()
    {
        tmAtencion = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        tmAtencion.text = "Atencion: " + controlarPuntos.cantidadPuntosAtencion.ToString("0") + "%";
    }

    public void SumarPuntosAtencion(int puntosObtenidos)
    {
        puntosAtencion += puntosObtenidos;
    }
}
