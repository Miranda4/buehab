using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeEnojo : MonoBehaviour
{
    private int puntosEnojo;
    private TextMeshProUGUI tmEnojo;

    private static controlarPuntos controlarPuntos;

    private void Start()
    {
        tmEnojo = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        
    }

    public void SumarPuntosEnojo(int puntosObtenidos)
    {
        puntosEnojo += puntosObtenidos;
    }
}
