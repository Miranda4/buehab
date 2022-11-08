using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System.Net;

public class puntajeDepresion : MonoBehaviour
{
    private float puntosDepresion;
    private TextMeshProUGUI tmDepresion;

    private static controlarPuntos controlarPuntos;


    private void Start()
    {
        tmDepresion = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
    }

    public void SumarPuntosDepresion(int puntosObtenidos) 
    { 
        puntosDepresion += puntosObtenidos;
    }
}
