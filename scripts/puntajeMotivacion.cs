using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeMotivacion : MonoBehaviour
{
    private int puntosMotivacion;
    private TextMeshProUGUI tmMotivacion;

    private static controlarPuntos controlarPuntos;

    private void Start()
    {
        tmMotivacion = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {

    }

    public void SumarPuntosMotivacion(int puntosObtenidos)
    {
        puntosMotivacion += puntosObtenidos;
    }
}
