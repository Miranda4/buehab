using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPersonaje2 : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float velocidadMovimientoPersonaje;
    [SerializeField] private float fuerzaSaltoPersonaje;
    [SerializeField] private LayerMask layer;

    private static controlarPuntos energiaP;
    private static controlarPuntos felicidadP;

    private void Start()
    {
        energiaP = FindObjectOfType<controlarPuntos>();
        felicidadP = FindObjectOfType<controlarPuntos>();
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        salto();
    }

    private void FixedUpdate()
    {

        float energiaTotal = (energiaP.cantidadPuntosEnergiaP + felicidadP.cantidadPuntosFelicidadP)/10;

        float velocidadInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(velocidadInput * (energiaTotal + velocidadMovimientoPersonaje), rb.velocity.y);
    }

    void salto()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * fuerzaSaltoPersonaje, ForceMode2D.Impulse);
        }
    }
}
