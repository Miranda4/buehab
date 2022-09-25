using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuInicial : MonoBehaviour
{
    public void Siguiente()
    {
        Debug.Log("Paso a siguiente escena.");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void salir()
    {
        Debug.Log("saliendo del juego");
        Application.Quit();
    }
} 
