using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeAtencionP : MonoBehaviour
{
    private int puntosAtencionP;
    private TextMeshProUGUI tmAtencionP;

    private static controlarPuntos controlarPuntos;

    private void Start()
    {
        tmAtencionP = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        tmAtencionP.text = "Atencion: " + controlarPuntos.cantidadPuntosAtencionP.ToString("0") + "%";
    }

    public void SumarPuntosAtencionP(int puntosObtenidos)
    {
        puntosAtencionP += puntosObtenidos;
    }
}
