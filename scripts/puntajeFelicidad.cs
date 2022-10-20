using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeFelicidad : MonoBehaviour
{
    private int puntosFelicidad;
    private TextMeshProUGUI tmFelicidad;

    private void Start()
    {
        tmFelicidad = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        tmFelicidad.text = "Felicidad: " + puntosFelicidad.ToString("0") + "%";
    }

    public void SumarPuntosFelicidad(int puntosObtenidos)
    {
        puntosFelicidad += puntosObtenidos;
    }
}
