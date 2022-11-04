using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeClaridadMental : MonoBehaviour
{
    private int puntosClaridadMental;
    private TextMeshProUGUI tmClaridadMental;

    private static controlarPuntos controlarPuntos;

    private void Start()
    {
        tmClaridadMental = GetComponent<TextMeshProUGUI>();
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    private void Update()
    {
        tmClaridadMental.text = "ClaridadMental: " + controlarPuntos.cantidadPuntosClaridadMental.ToString("0") + "%";
    }

    public void SumarPuntosClaridadMental(int puntosObtenidos)
    {
        puntosClaridadMental += puntosObtenidos;
    }
}
