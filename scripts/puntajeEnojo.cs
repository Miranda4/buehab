using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeEnojo : MonoBehaviour
{
    private int puntosEnojo;
    private TextMeshProUGUI tmEnojo;

    private void Start()
    {
        tmEnojo = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        tmEnojo.text = "Enojo: " + puntosEnojo.ToString("0") + "%";
    }

    public void SumarPuntosEnojo(int puntosObtenidos)
    {
        puntosEnojo += puntosObtenidos;
    }
}
