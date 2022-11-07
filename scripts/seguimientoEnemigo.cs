using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguimientoEnemigo : MonoBehaviour
{
    public GameObject jugador;
    public float velocidadEnemigo;

    private float distancia;

    void Start()
    {
        
    }

    void Update()
    {
        distancia = Vector2.Distance(transform.position, jugador.transform.position);
        Vector2 direction = jugador.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, jugador.transform.position, velocidadEnemigo * Time.deltaTime);
    }
}
