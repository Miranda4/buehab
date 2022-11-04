using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeAlimentacionP : MonoBehaviour
{
    private int puntosAlimentacionP;
    private TextMeshProUGUI tmAlimentacionP;

    private static controlarPuntos controlarPuntos;

    private void Start()
    {
        tmAlimentacionP = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        tmAlimentacionP.text = "Alimentacion: " + controlarPuntos.cantidadPuntosAlimentacionP.ToString("0") + "%";
    }

    public void SumarPuntosAlimentacionP(int puntosObtenidos)
    {
        puntosAlimentacionP += puntosObtenidos;
    }
}
