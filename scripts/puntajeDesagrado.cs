using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeDesagrado : MonoBehaviour
{
    private int puntosDesagrado;
    private TextMeshProUGUI tmDesagrado;

    private static controlarPuntos controlarPuntos;

    private void Start()
    {
        tmDesagrado = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        tmDesagrado.text = "Desagrado: " + controlarPuntos.cantidadPuntosDesagrado.ToString("0") + "%";
    }

    public void SumarPuntosDesagrado(int puntosObtenidos)
    {
        puntosDesagrado += puntosObtenidos;
    }
}
