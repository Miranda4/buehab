using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject objeto;

    float randX;

    
    Vector2 spawnPosition;

    public float tiempoSpawn = 2f;

    float sigSpawn = 0.0f;

    public float posIni;
    public float posFin;


    void Start()
    {
        
    }

    void Update()
    {
        if (Time.time > sigSpawn)
        {
            sigSpawn = Time.time + tiempoSpawn;
            randX = Random.Range(posIni, posFin);
            spawnPosition = new Vector2(randX, transform.position.y);
            Instantiate(objeto, spawnPosition, Quaternion.identity);
        }
    }
}
