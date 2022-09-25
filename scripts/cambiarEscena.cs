using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarEscena : MonoBehaviour
{

    public string nombreNivel;

    public void nivel(string nombreNivel)
    {
        SceneManager.LoadScene(nombreNivel);
    }
}
