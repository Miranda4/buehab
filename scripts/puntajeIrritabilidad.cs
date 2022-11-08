using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System.Net;

public class puntajeIrritabilidad : MonoBehaviour
{
    private float puntosIrritabilidad;
    private TextMeshProUGUI tmIrritabilidad;

    private static controlarPuntos controlarPuntos;


    private void Start()
    {
        tmIrritabilidad = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        
    }

    public void SumarPuntosIrritabilidad(int puntosObtenidos) 
    { 
        puntosIrritabilidad += puntosObtenidos;
    }
}
