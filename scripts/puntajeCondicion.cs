using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeCondicion : MonoBehaviour
{
    private int puntosCondicion;
    private TextMeshProUGUI tmCondicion;

    private static controlarPuntos controlarPuntos;

    private void Start()
    {
        tmCondicion = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        
    }

    public void SumarPuntosCondicion(int puntosObtenidos)
    {
        puntosCondicion += puntosObtenidos;
    }
}
