using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeCondicionP : MonoBehaviour
{
    private int puntosCondicionP;
    private TextMeshProUGUI tmCondicionP;

    private static controlarPuntos controlarPuntos;

    private void Start()
    {
        tmCondicionP = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        tmCondicionP.text = "Condicion: " + controlarPuntos.cantidadPuntosCondicionP.ToString("0") + "%";
    }

    public void SumarPuntosCondicionP(int puntosObtenidos)
    {
        puntosCondicionP += puntosObtenidos;
    }
}
