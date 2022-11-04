using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeAlimentacion : MonoBehaviour
{
    private int puntosAlimentacion;
    private TextMeshProUGUI tmAlimentacion;

    private static controlarPuntos controlarPuntos;

    private void Start()
    {
        tmAlimentacion = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        tmAlimentacion.text = "Alimentacion: " + controlarPuntos.cantidadPuntosAlimentacion.ToString("0") + "%";
    }

    public void SumarPuntosAlimentacion(int puntosObtenidos)
    {
        puntosAlimentacion += puntosObtenidos;
    }
}
