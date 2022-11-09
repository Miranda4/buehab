using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reiniciarPuntosUsuario : MonoBehaviour
{
    private static controlarPuntos felicidad;
    private static controlarPuntos energia;
    private static controlarPuntos irritabilidad;
    private static controlarPuntos estres;
    private static controlarPuntos ansiedad;
    private static controlarPuntos obesidad;
    private static controlarPuntos salud;
    private static controlarPuntos depresion;

    void Start()
    {
        felicidad = FindObjectOfType<controlarPuntos>();
        energia = FindObjectOfType<controlarPuntos>();
        irritabilidad = FindObjectOfType<controlarPuntos>();
        estres = FindObjectOfType<controlarPuntos>();
        ansiedad = FindObjectOfType<controlarPuntos>();
        obesidad = FindObjectOfType<controlarPuntos>();
        salud = FindObjectOfType<controlarPuntos>();
        depresion = FindObjectOfType<controlarPuntos>();
    }

    public void reiniciarPuntajeUsuario()
    {
        felicidad.cantidadPuntosFelicidad = 0;
        energia.cantidadPuntosEnergia = 0;
        irritabilidad.cantidadPuntosIrritabilidad = 0;
        estres.cantidadPuntosEstres = 0;
        ansiedad.cantidadPuntosAnsiedad = 0;
        obesidad.cantidadPuntosObesidad = 0;
        salud.cantidadPuntosSalud = 0;
        depresion.cantidadPuntosDepresion = 0;
    }
}
