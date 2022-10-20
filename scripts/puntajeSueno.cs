using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeSueno : MonoBehaviour
{
    private int puntosSueno;
    private TextMeshProUGUI tmSueno;

    private void Start()
    {
        tmSueno = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        tmSueno.text = "Sueño: " + puntosSueno.ToString("0") + "%";
    }

    public void SumarPuntosSueno(int puntosObtenidos)
    {
        puntosSueno += puntosObtenidos;
    }
}
