using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class noMasObjetos : MonoBehaviour
{

    [SerializeField] private int cantidadObjetos;
    [SerializeField] private int objetosDestruidos;
    public GameObject boton1;
    public GameObject boton2;

    // Start is called before the first frame update
    void Start()
    {
        cantidadObjetos = GameObject.FindGameObjectsWithTag("objeto").Length;
    }
    void Update()
    {
        if (cantidadObjetos == 0)
        {
            Debug.Log("Ya no hay objetos");
            boton1.SetActive(true);
            boton2.SetActive(true);
        }
    }
}
