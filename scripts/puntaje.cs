using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntaje : MonoBehaviour
{
    private int puntos;

    private TextMeshProUGUI tm;


    private void Start()
    {
        tm = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        tm.text = "Puntos: " + puntos.ToString("0");
    }

    public void SumarPuntos(int puntosObtenidos)
    {
        puntos += puntosObtenidos;
    }
}
