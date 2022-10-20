using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeDesagrado : MonoBehaviour
{
    private int puntosDesagrado;
    private TextMeshProUGUI tmDesagrado;

    private void Start()
    {
        tmDesagrado = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        tmDesagrado.text = "Desagrado: " + puntosDesagrado.ToString("0") + "%";
    }

    public void SumarPuntosDesagrado(int puntosObtenidos)
    {
        puntosDesagrado += puntosObtenidos;
    }
}
