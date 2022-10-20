using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajeTristeza : MonoBehaviour
{
    private float puntosTristeza;
    private TextMeshProUGUI tmTristeza;

    private void Start()
    {
        tmTristeza = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        tmTristeza.text = "Tristeza: " + puntosTristeza.ToString("0") + "%";
    }

    public void SumarPuntosTristeza(int puntosObtenidos) 
    { 
        puntosTristeza += puntosObtenidos;
    }
}
