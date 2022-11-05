using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarEscena : MonoBehaviour
{

    public string nombreNivel;

    private static controlarPuntos energiaP;
    private static controlarPuntos felicidadP;

    public void Awake()
    {
        energiaP = FindObjectOfType<controlarPuntos>();
        felicidadP = FindObjectOfType<controlarPuntos>();
    }

    public void nivel(string nombreNivel)
    {
        if (nombreNivel == "mj-horasDeSueno")
        {
            energiaP.cantidadPuntosEnergiaP = 0;
            energiaP.cantidadPuntosFelicidadP = 0;
            SceneManager.LoadScene(nombreNivel);
        }
        SceneManager.LoadScene(nombreNivel);
    }
}
