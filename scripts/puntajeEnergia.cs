using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeEnergia : MonoBehaviour
{
    private int puntosEnergia;
    private TextMeshProUGUI tmEnergia;

    private void Start()
    {
        tmEnergia = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        tmEnergia.text = "Energia: " + puntosEnergia.ToString("0") + "%";
    }

    public void SumarPuntosEnergia(int puntosObtenidos)
    {
        puntosEnergia += puntosObtenidos;
    }
}
