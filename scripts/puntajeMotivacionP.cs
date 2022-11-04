using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeMotivacionP : MonoBehaviour
{
    private int puntosMotivacionP;
    private TextMeshProUGUI tmMotivacionP;

    private static controlarPuntos controlarPuntos;

    private void Start()
    {
        tmMotivacionP = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        tmMotivacionP.text = "Motivacion: " + controlarPuntos.cantidadPuntosMotivacionP.ToString("0") + "%";
    }

    public void SumarPuntosMotivacionP(int puntosObtenidos)
    {
        puntosMotivacionP += puntosObtenidos;
    }
}
