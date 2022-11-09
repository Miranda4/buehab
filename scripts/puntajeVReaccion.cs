using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeVReaccion : MonoBehaviour
{
    private int puntosVReaccion;
    private TextMeshProUGUI tmVReaccion;

    private static controlarPuntos controlarPuntos;

    private void Start()
    {
        tmVReaccion = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {

    }

    public void SumarPuntosVReaccion(int puntosObtenidos)
    {
        puntosVReaccion += puntosObtenidos;
    }
}
