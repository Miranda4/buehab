using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeEnergiaP : MonoBehaviour
{
    private int puntosEnergiaP;
    private TextMeshProUGUI tmEnergiaP;

    private static controlarPuntos controlarPuntos;

    private void Start()
    {
        tmEnergiaP = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        tmEnergiaP.text = "Energia: " + controlarPuntos.cantidadPuntosEnergiaP.ToString("0") + "%";
    }

    public void SumarPuntosEnergiaP(int puntosObtenidos)
    {
        puntosEnergiaP += puntosObtenidos;
    }
}
