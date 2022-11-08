using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeSalud : MonoBehaviour
{
    private int puntosSalud;
    private TextMeshProUGUI tmSalud;

    private static controlarPuntos controlarPuntos;

    private void Start()
    {
        tmSalud = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
    }

    public void SumarPuntosSalud(int puntosObtenidos)
    {
        puntosSalud += puntosObtenidos;
    }
}
