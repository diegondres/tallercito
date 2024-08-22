using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prota : MonoBehaviour
{
    private Rigidbody rb;   // Componente Rigidbody2D para gestionar la física
    private GameController gameController;
    public float speed = 5.0f;    // Velocidad de movimiento
    public float jumpForce = 10.0f;   // Fuerza del salto
    private bool isGrounded = true;   // Para verificar si el jugador está en el suelo
    public int vidas = 3;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Obtiene el componente Rigidbody2D del objeto al que está adjunto este script
        gameController = FindObjectOfType<GameController>();
        gameController.UpdateVidas(vidas);
    }

    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Obtener la entrada de movimiento horizontal (A/D o flechas izquierda/derecha)
        rb.velocity = new Vector3(horizontalInput * speed, rb.velocity.y); // Mover el Rigidbody2D horizontalmente
    }

    void Jump()
    {
        rb.AddForce(new Vector3(0, jumpForce,0), ForceMode.Impulse); // Aplicar una fuerza hacia arriba para saltar
        isGrounded = false;  // Asumir que el jugador deja de estar en el suelo cuando salta
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Asegurar que el jugador solo puede saltar si está tocando el suelo
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Colision!!!s");
            isGrounded = true;
        }
        
        if (collision.gameObject.CompareTag("Daño"))
        {
            Debug.Log("Auch!");
            vidas -= 1;
            gameController.UpdateVidas(vidas);
            if(vidas == 0){
                //Hacer cositas de moricion
            }
        }
    }
}
