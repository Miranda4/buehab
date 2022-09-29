using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetoPuntos : MonoBehaviour
{
    [SerializeField] private int cantidadPuntos;
    [SerializeField] private puntaje puntaje;
    [SerializeField] private string escena;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            controlarPuntos.instance.sumarPuntos(cantidadPuntos);
            puntaje.SumarPuntos(cantidadPuntos);
            Destroy(gameObject);
        }
    }
}
