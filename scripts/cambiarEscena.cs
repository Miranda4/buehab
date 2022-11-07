using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarEscena : MonoBehaviour
{

    public string nombreNivel;


    private static controlarPuntos energiaP;
    private static controlarPuntos puntos;
    private static controlarPuntos motivacionP;
    private static controlarPuntos condicionP;
    private static controlarPuntos atencionP;
    private static controlarPuntos felicidadP;
    private static controlarPuntos alimentacionP;


    public void Awake()
    {
        energiaP = FindObjectOfType<controlarPuntos>();
        puntos = FindObjectOfType<controlarPuntos>();
        motivacionP = FindObjectOfType<controlarPuntos>();
        condicionP = FindObjectOfType<controlarPuntos>();
        atencionP = FindObjectOfType<controlarPuntos>();
        felicidadP = FindObjectOfType<controlarPuntos>();
        alimentacionP = FindObjectOfType<controlarPuntos>();
    }

    public void nivel(string nombreNivel)
    {
        //if(nombreNivel == "mj-decideActividad")
        //{
            energiaP.cantidadPuntosEnergiaP = 0;
            puntos.cantidadPuntos = 0;
            motivacionP.cantidadPuntosMotivacionP = 0;
            condicionP.cantidadPuntosCondicionP = 0;
            atencionP.cantidadPuntosAtencionP = 0;
            felicidadP.cantidadPuntosFelicidadP = 0;
            alimentacionP.cantidadPuntosAlimentacionP = 0;
        //}
        SceneManager.LoadScene(nombreNivel);
    }
}
