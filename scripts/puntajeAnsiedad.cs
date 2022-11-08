using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System.Net;

public class puntajeAnsiedad : MonoBehaviour
{
    private float puntosAnsiedad;
    private TextMeshProUGUI tmAnsiedad;

    private static controlarPuntos controlarPuntos;


    private void Start()
    {
        tmAnsiedad = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        
    }

    public void SumarPuntosAnsiedad(int puntosObtenidos) 
    { 
        puntosAnsiedad += puntosObtenidos;
    }
}
