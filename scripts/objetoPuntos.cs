using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetoPuntos : MonoBehaviour
{
    [SerializeField] private int cantidadPuntos;
    [SerializeField] private puntaje puntaje;

    [SerializeField] private int cantidadPuntosFelicidadP;
    [SerializeField] private puntajeFelicidadP puntajeFelicidadP;

    [SerializeField] private int cantidadPuntosEnergiaP;
    [SerializeField] private puntajeEnergiaP puntajeEnergiaP;

    [SerializeField] private int cantidadPuntosAlimentacionP;
    [SerializeField] private puntajeAlimentacionP puntajeAlimentacionP;

    [SerializeField] private int cantidadPuntosAtencionP;
    [SerializeField] private puntajeAtencionP puntajeAtencionP;

    [SerializeField] private int cantidadPuntosCondicionP;
    [SerializeField] private puntajeCondicionP puntajeCondicionP;

    [SerializeField] private int cantidadPuntosMotivacionP;
    [SerializeField] private puntajeMotivacionP puntajeMotivacionP;

    /*[SerializeField] private int cantidadPuntosFelicidad;
    [SerializeField] private puntajeFelicidad puntajeFelicidad;

    [SerializeField] private int cantidadPuntosSueno;
    [SerializeField] private puntajeSueno puntajeSueno;

    [SerializeField] private int cantidadPuntosEnergia;
    [SerializeField] private puntajeEnergia puntajeEnergia;

    [SerializeField] private int cantidadPuntosTristeza;
    [SerializeField] private puntajeTristeza puntajeTristeza;

    [SerializeField] private int cantidadPuntosSalud;
    [SerializeField] private puntajeSalud puntajeSalud;

    [SerializeField] private int cantidadPuntosEnojo;
    [SerializeField] private puntajeEnojo puntajeEnojo;

    [SerializeField] private int cantidadPuntosIrritabilidad;
    [SerializeField] private puntajeIrritabilidad puntajeIrritabilidad;

    [SerializeField] private int cantidadPuntosEstres;
    [SerializeField] private puntajeEstres puntajeEstres;

    [SerializeField] private int cantidadPuntosDepresion;
    [SerializeField] private puntajeDepresion puntajeDepresion;
    
    [SerializeField] private int cantidadPuntosAnsiedad;
    [SerializeField] private puntajeAnsiedad puntajeAnsiedad;

    [SerializeField] private int cantidadPuntosMemoria;
    [SerializeField] private puntajeMemoria puntajeMemoria;

    [SerializeField] private int cantidadPuntosVReaccion;
    [SerializeField] private puntajeVReaccion puntajeVReaccion;

    [SerializeField] private int cantidadPuntosClaridadMental;
    [SerializeField] private puntajeClaridadMental puntajeClaridadMental;

    [SerializeField] private int cantidadPuntosAlimentacion;
    [SerializeField] private puntajeAlimentacion puntajeAlimentacion;*/

    [SerializeField] private string escena;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //puntaje general del objeto para mostar en general
            controlarPuntos.instance.sumarPuntos(cantidadPuntos);
            puntaje.SumarPuntos(cantidadPuntos);

            controlarPuntos.instance.sumarPuntosFelicidadP(cantidadPuntosFelicidadP);
            puntajeFelicidadP.SumarPuntosFelicidadP(cantidadPuntosFelicidadP);

            controlarPuntos.instance.sumarPuntosEnergiaP(cantidadPuntosEnergiaP);
            puntajeEnergiaP.SumarPuntosEnergiaP(cantidadPuntosEnergiaP);

            controlarPuntos.instance.sumarPuntosAlimentacionP(cantidadPuntosAlimentacionP);
            puntajeAlimentacionP.SumarPuntosAlimentacionP(cantidadPuntosAlimentacionP);

            controlarPuntos.instance.sumarPuntosAtencionP(cantidadPuntosAtencionP);
            puntajeAtencionP.SumarPuntosAtencionP(cantidadPuntosAtencionP);

            controlarPuntos.instance.sumarPuntosCondicionP(cantidadPuntosCondicionP);
            puntajeCondicionP.SumarPuntosCondicionP(cantidadPuntosCondicionP);

            controlarPuntos.instance.sumarPuntosMotivacionP(cantidadPuntosMotivacionP);
            puntajeMotivacionP.SumarPuntosMotivacionP(cantidadPuntosMotivacionP);

            /*controlarPuntos.instance.sumarPuntosFelicidad(cantidadPuntosFelicidad);
            puntajeFelicidad.SumarPuntosFelicidad(cantidadPuntosFelicidad);

            controlarPuntos.instance.sumarPuntosSueno(cantidadPuntosSueno);
            puntajeSueno.SumarPuntosSueno(cantidadPuntosSueno);

            controlarPuntos.instance.sumarPuntosEnergia(cantidadPuntosEnergia);
            puntajeEnergia.SumarPuntosEnergia(cantidadPuntosEnergia);

            controlarPuntos.instance.sumarPuntosTristeza(cantidadPuntosTristeza);
            puntajeTristeza.SumarPuntosTristeza(cantidadPuntosTristeza);

            controlarPuntos.instance.sumarPuntosSalud(cantidadPuntosSalud);
            puntajeSalud.SumarPuntosSalud(cantidadPuntosSalud);

            controlarPuntos.instance.sumarPuntosEnojo(cantidadPuntosEnojo);
            puntajeEnojo.SumarPuntosEnojo(cantidadPuntosEnojo);

            controlarPuntos.instance.sumarPuntosIrritabilidad(cantidadPuntosIrritabilidad);
            puntajeIrritabilidad.SumarPuntosIrritabilidad(cantidadPuntosIrritabilidad);

            controlarPuntos.instance.sumarPuntosEstres(cantidadPuntosEstres);
            puntajeEstres.SumarPuntosEstres(cantidadPuntosEstres);

            controlarPuntos.instance.sumarPuntosDepresion(cantidadPuntosDepresion);
            puntajeDepresion.SumarPuntosDepresion(cantidadPuntosDepresion);

            controlarPuntos.instance.sumarPuntosAnsiedad(cantidadPuntosAnsiedad);
            puntajeAnsiedad.SumarPuntosAnsiedad(cantidadPuntosAnsiedad);

            controlarPuntos.instance.sumarPuntosMemoria(cantidadPuntosMemoria);
            puntajeMemoria.SumarPuntosMemoria(cantidadPuntosMemoria);

            controlarPuntos.instance.sumarPuntosVReaccion(cantidadPuntosVReaccion);
            puntajeVReaccion.SumarPuntosVReaccion(cantidadPuntosVReaccion);

            controlarPuntos.instance.sumarPuntosClaridadMental(cantidadPuntosClaridadMental);
            puntajeClaridadMental.SumarPuntosClaridadMental(cantidadPuntosClaridadMental);

            controlarPuntos.instance.sumarPuntosAlimentacion(cantidadPuntosAlimentacion);
            puntajeAlimentacion.SumarPuntosAlimentacion(cantidadPuntosAlimentacion);*/

            Destroy(gameObject);
        }
    }
}
