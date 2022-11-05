using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botonReinicio : MonoBehaviour
{

    [SerializeField] private int cantidadObjetos;
    [SerializeField] private int objetosDestruidos;
    public GameObject boton1;
    public GameObject boton2;

    void Start()
    {
        //cantidadObjetos = GameObject.FindGameObjectsWithTag("objeto").Length;
    }
    void Update()
    {
        cantidadObjetos = GameObject.FindGameObjectsWithTag("player").Length;
        if (cantidadObjetos == 0)
        {
            Debug.Log("Ya no hay objetos");
            boton1.SetActive(true);
            boton2.SetActive(true);
        }
    }
}