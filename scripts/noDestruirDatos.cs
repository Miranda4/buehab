using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noDestruirDatos : MonoBehaviour
{
    public static noDestruirDatos instance;
    private void Awake()
    {
        if (noDestruirDatos.instance == null)
        {
            noDestruirDatos.instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
