using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public float FORCE_INCREMENT;
    //public float INERTIA_INCREMENT;
    //public float INERTIA_DECREMENT;

    //private float speed;
    private Rigidbody2D rb;
    //private Vector2 velocity;
    private Vector2 direction;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //if (isMoving())
        //{
        //    direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        //    if (speed < MAX_SPEED)
        //    {
        //        speed += INERTIA_INCREMENT;
        //    } else if (speed > MAX_SPEED)
        //    {
        //        speed = MAX_SPEED;
        //    }
        //} else
        //{            
        //    if (speed > 0)
        //    {
        //        speed -= INERTIA_DECREMENT;
        //    } else if (speed < 0)
        //    {
        //        speed = 0;
        //    }
        //}

        //velocity = direction * speed;

        //rb.MovePosition(rb.position + velocity * Time.deltaTime);

        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        rb.AddForce(direction * FORCE_INCREMENT);
    }

    ///// <summary>
    ///// Verifica si el jugador está haciendo un input de movimiento.
    ///// </summary>
    ///// <returns>Verdadero si el jugador se está moviendo.</returns>
    //private bool isMoving()
    //{
    //    return Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0;
    //}

    ///// <summary>
    ///// Verifica si hubo un cambio de dirección brusco sobre el eje X.
    ///// </summary>
    ///// <returns>Verdadero si se cambió completamente la dirección sobre el eje X.</returns>
    //private bool changedDirectionX()
    //{
    //    return Mathf.Sign(previousDirection.x) != Mathf.Sign(Input.GetAxisRaw("Horizontal"));
    //}
    //private bool changedDirectionY()
    //{
    //    return Mathf.Sign(previousDirection.y) != Mathf.Sign(Input.GetAxisRaw("Vertical"));
    //}

}
