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
        tmSalud.text = "Salud: " + controlarPuntos.cantidadPuntosSalud.ToString("0") + "%";
    }

    public void SumarPuntosSalud(int puntosObtenidos)
    {
        puntosSalud += puntosObtenidos;
    }
}
