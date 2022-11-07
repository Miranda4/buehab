using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class noMasObjetos : MonoBehaviour
{

    [SerializeField] private int cantidadObjetos;
    [SerializeField] private int enemigosTotales;
    [SerializeField] private int objetosDestruidos;

    public GameObject boton1;
    public GameObject jugador;
    public GameObject enemigo;
    public GameObject spawner;

    void Start()
    {
        
    }
    void Update()
    {
        cantidadObjetos = GameObject.FindGameObjectsWithTag("objeto").Length;
        if (cantidadObjetos == 0)
        {
            enemigosTotales = GameObject.FindGameObjectsWithTag("enemigo").Length;
            boton1.SetActive(true);
            jugador.SetActive(false);
            Destroy(spawner.gameObject);

            for(int i = 0; i < enemigosTotales; i++)
            {
                Destroy(GameObject.FindGameObjectsWithTag("enemigo")[i]);
            }
        }
    }
}