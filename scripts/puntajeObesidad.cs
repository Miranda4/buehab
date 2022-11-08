using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System.Net;

public class puntajeObesidad : MonoBehaviour
{
    private float puntosObesidad;
    private TextMeshProUGUI tmObesidad;

    private static controlarPuntos controlarPuntos;


    private void Start()
    {
        tmObesidad = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        
    }

    public void SumarPuntosObesidad(int puntosObtenidos) 
    { 
        puntosObesidad += puntosObtenidos;
    }
}
