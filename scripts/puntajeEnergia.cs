using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeEnergia : MonoBehaviour
{
    private int puntosEnergia;
    private TextMeshProUGUI tmEnergia;

    private static controlarPuntos controlarPuntos;

    private void Start()
    {
        tmEnergia = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        
    }

    public void SumarPuntosEnergia(int puntosObtenidos)
    {
        puntosEnergia += puntosObtenidos;
    }
}
