using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System.Net;

public class puntajeMemoria : MonoBehaviour
{
    private float puntosMemoria;
    private TextMeshProUGUI tmMemoria;

    private static controlarPuntos controlarPuntos;


    private void Start()
    {
        tmMemoria = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        
    }

    public void SumarPuntosMemoria(int puntosObtenidos) 
    { 
        puntosMemoria += puntosObtenidos;
    }
}
