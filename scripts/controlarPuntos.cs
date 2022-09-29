using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlarPuntos : MonoBehaviour
{
    public static controlarPuntos instance;
    [SerializeField] private float cantidadPuntos;

    private void Awake()
    {
        if(controlarPuntos.instance == null)
        {
            controlarPuntos.instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void sumarPuntos(float puntos)
    {
        cantidadPuntos += puntos;
    }


}