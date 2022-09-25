using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPersonaje : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D bc;
    [SerializeField] private float velocidadMovimientoPersonaje;
    [SerializeField] private float fuerzaSaltoPersonaje;
    [SerializeField] private LayerMask layer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        salto();
    }

    private void FixedUpdate()
    {
        float velocidadInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(velocidadInput * velocidadMovimientoPersonaje, rb.velocity.y);
    }

    bool enSuelo()
    {
        RaycastHit2D rch = Physics2D.BoxCast(bc.bounds.center, new Vector2(bc.bounds.size.x, bc.bounds.size.y), 0f, Vector2.down, 0.2f, layer);
        return rch.collider != null;
    }

    void salto()
    {
        if (Input.GetKeyDown(KeyCode.Space) && enSuelo())
        {
            rb.AddForce(Vector2.up * fuerzaSaltoPersonaje, ForceMode2D.Impulse);
        }
    }
}
