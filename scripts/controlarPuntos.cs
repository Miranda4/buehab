using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlarPuntos : MonoBehaviour
{
    public static controlarPuntos instance;

    [SerializeField] public float cantidadPuntos;
    [SerializeField] public float cantidadPuntosFelicidad;
    [SerializeField] public float cantidadPuntosSueno;
    [SerializeField] public float cantidadPuntosEnergia;
    [SerializeField] public float cantidadPuntosTristeza;
    [SerializeField] public float cantidadPuntosSalud;
    [SerializeField] public float cantidadPuntosEnojo;
    [SerializeField] public float cantidadPuntosIrritabilidad;
    [SerializeField] public float cantidadPuntosEstres;
    [SerializeField] public float cantidadPuntosDepresion;
    [SerializeField] public float cantidadPuntosAnsiedad;
    [SerializeField] public float cantidadPuntosMemoria;
    [SerializeField] public float cantidadPuntosVReaccion;
    [SerializeField] public float cantidadPuntosClaridadMental;
    [SerializeField] public float cantidadPuntosAlimentacion;
    [SerializeField] public float cantidadPuntosAtencion;
    [SerializeField] public float cantidadPuntosCondicion;
    [SerializeField] public float cantidadPuntosMotivacion;
    [SerializeField] public float cantidadPuntosEnergiaP;
    [SerializeField] public float cantidadPuntosFelicidadP;
    [SerializeField] public float cantidadPuntosAlimentacionP;
    [SerializeField] public float cantidadPuntosAtencionP;
    [SerializeField] public float cantidadPuntosCondicionP;
    [SerializeField] public float cantidadPuntosMotivacionP;

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

    public void sumarPuntosCondicionP(float puntos)
    {
        cantidadPuntosCondicionP+= puntos;
    }

    public void sumarPuntosAtencionP(float puntos)
    {
        cantidadPuntosAtencionP += puntos;
    }

    public void sumarPuntosAlimentacionP(float puntos)
    {
        cantidadPuntosAlimentacionP += puntos;
    }

    public void sumarPuntosFelicidadP(float puntos)
    {
        cantidadPuntosFelicidadP += puntos;
    }

    public void sumarPuntosEnergiaP(float puntos)
    {
        cantidadPuntosEnergiaP += puntos;
    }

    public void sumarPuntosMotivacionP(float puntos)
    {
        cantidadPuntosMotivacionP += puntos;
    }

    public void sumarPuntosMotivacion(float puntos)
    {
        cantidadPuntosMotivacion += puntos;
    }
    
    public void sumarPuntosCondicion(float puntos)
    {
        cantidadPuntosCondicion += puntos;
    }
    
    public void sumarPuntosAtencion(float puntos)
    {
        cantidadPuntosAtencion += puntos;
    }

    public void sumarPuntosAlimentacion(float puntos)
    {
        cantidadPuntosAlimentacion += puntos;
    }

    public void sumarPuntosClaridadMental(float puntos)
    {
        cantidadPuntosClaridadMental += puntos;
    }

    public void sumarPuntosVReaccion(float puntos)
    {
        cantidadPuntosVReaccion += puntos;
    }

    public void sumarPuntosMemoria(float puntos)
    {
        cantidadPuntosMemoria += puntos;
    }

    public void sumarPuntosAnsiedad(float puntos)
    {
        cantidadPuntosAnsiedad += puntos;
    }

    public void sumarPuntosDepresion(float puntos)
    {
        cantidadPuntosDepresion += puntos;
    }

    public void sumarPuntosEstres(float puntos)
    {
        cantidadPuntosEstres += puntos;
    }

    public void sumarPuntosIrritabilidad(float puntos)
    {
        cantidadPuntosIrritabilidad += puntos;
    }

    public void restablecerPuntaje()
    {
        cantidadPuntos = 0;
    }

    public void sumarPuntos(float puntos)
    {
        cantidadPuntos += puntos;
    }

    public void sumarPuntosFelicidad(float puntos)
    {
        cantidadPuntosFelicidad += puntos;
    }
    public void sumarPuntosSueno(float puntos)
    {
        cantidadPuntosSueno += puntos;
    }
    public void sumarPuntosEnergia(float puntos)
    {
        cantidadPuntosEnergia += puntos;
    }
    public void sumarPuntosTristeza(float puntos)
    {
        cantidadPuntosTristeza += puntos;
    }
    public void sumarPuntosSalud(float puntos)
    {
        cantidadPuntosSalud += puntos;
    }
    public void sumarPuntosEnojo(float puntos)
    {
        cantidadPuntosEnojo += puntos;
    }

}