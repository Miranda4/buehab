using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restablecerPuntajeMJ : MonoBehaviour
{
    private void Awake()
    {
        controlarPuntos.instance.restablecerPuntaje();
    }
}
