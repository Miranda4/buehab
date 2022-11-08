using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System.Net;

public class puntajeEstres : MonoBehaviour
{
    private float puntosEstres;
    private TextMeshProUGUI tmEstres;

    private static controlarPuntos controlarPuntos;


    private void Start()
    {
        tmEstres = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        
    }

    public void SumarPuntosEstres(int puntosObtenidos) 
    { 
        puntosEstres += puntosObtenidos;
    }
}
