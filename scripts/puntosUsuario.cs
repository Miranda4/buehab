using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntosUsuario : MonoBehaviour
{
    private static controlarPuntos alimentacion;
    private static controlarPuntos ansiedad;
    private static controlarPuntos claridadMental;
    private static controlarPuntos depresion;
    private static controlarPuntos energia;
    private static controlarPuntos enojo;
    private static controlarPuntos estres;
    private static controlarPuntos felicidad;
    private static controlarPuntos irritabilidad;
    private static controlarPuntos memoria;
    private static controlarPuntos salud;
    private static controlarPuntos sueno;
    private static controlarPuntos tristeza;
    private static controlarPuntos vReaccion;

    void Start()
    {
        alimentacion = FindObjectOfType<controlarPuntos>();
        ansiedad = FindObjectOfType<controlarPuntos>();
        claridadMental = FindObjectOfType<controlarPuntos>();
        depresion = FindObjectOfType<controlarPuntos>();
        energia = FindObjectOfType<controlarPuntos>();
        enojo = FindObjectOfType<controlarPuntos>();
        estres = FindObjectOfType<controlarPuntos>();
        felicidad = FindObjectOfType<controlarPuntos>();
        irritabilidad = FindObjectOfType<controlarPuntos>();
        memoria = FindObjectOfType<controlarPuntos>();
        salud = FindObjectOfType<controlarPuntos>();
        sueno = FindObjectOfType<controlarPuntos>();
        tristeza= FindObjectOfType<controlarPuntos>();
        vReaccion = FindObjectOfType<controlarPuntos>();

    }

    void Update()
    {
        
    }

 
    public void SumarPuntosAnsiedad(int puntosObtenidos)
    {
        ansiedad.cantidadPuntosAnsiedad += puntosObtenidos;
    }
    public void SumarPuntosDepresion(int puntosObtenidos)
    {
        depresion.cantidadPuntosDepresion+= puntosObtenidos;
    }

    public void SumarPuntosEnergia(int puntosObtenidos)
    {
        energia.cantidadPuntosEnergia+= puntosObtenidos;
    }


    public void SumarPuntosEstres(int puntosObtenidos)
    {
        estres.cantidadPuntosEstres+= puntosObtenidos;
    }

    public void SumarPuntosFelicidad(int puntosObtenidos)
    {
        felicidad.cantidadPuntosFelicidad+= puntosObtenidos;
    }

    public void SumarPuntosIrritabilidad(int puntosObtenidos)
    {
        irritabilidad.cantidadPuntosIrritabilidad+= puntosObtenidos;
    }


    public void SumarPuntosSalud(int puntosObtenidos)
    {
        salud.cantidadPuntosSalud+= puntosObtenidos;
    }



}
