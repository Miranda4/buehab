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

    void Start()
    {
        //cantidadObjetos = GameObject.FindGameObjectsWithTag("objeto").Length;
    }
    void Update()
    {
        cantidadObjetos = GameObject.FindGameObjectsWithTag("objeto").Length;
        if (cantidadObjetos == 0)
        {
            boton1.SetActive(true);

        }
    }
}