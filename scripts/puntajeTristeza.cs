using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System.Net;

public class puntajeTristeza : MonoBehaviour
{
    private float puntosTristeza;
    private TextMeshProUGUI tmTristeza;

    private static controlarPuntos controlarPuntos;


    private void Start()
    {
        tmTristeza = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {

    }

    public void SumarPuntosTristeza(int puntosObtenidos) 
    { 
        puntosTristeza += puntosObtenidos;
    }
}
