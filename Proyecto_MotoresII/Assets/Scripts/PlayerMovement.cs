using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f; // Speed of the player

    public float VelocidadCorriendo = 10f;

    public TMP_Text TextoStamina;

    public float stamina = 100f;
    public float StaminaMax = 100f;

    public float GastoDeStamina = 10f;
    public float RegenDeStamina = 5f;
    public float CooldownDeStamina = 2f;

    private float VelocidadActual;
    private float staminaCooldown;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        VelocidadActual = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        TextoStamina.text = stamina.ToString();

    }

    void Move()
    {
        // Get input from horizontal and vertical axes
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 movement;

        // Calculate movement direction
        

        if (Input.GetKey(KeyCode.LeftShift) && stamina > 0 && rb.velocity != Vector3.zero)
        {
            movement = new Vector3(moveX, 0, moveZ) * VelocidadCorriendo;

            // Apply movement to the Rigidbody
            rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
            stamina -= GastoDeStamina * Time.deltaTime;
            staminaCooldown = CooldownDeStamina;
        }

      else
        {
            movement = new Vector3(moveX, 0, moveZ) * moveSpeed;
            rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

        }
            if (stamina < StaminaMax)
            {
                if (staminaCooldown > 0)
                {
                    staminaCooldown -= Time.deltaTime;
                }
                else
                {
                    stamina += RegenDeStamina * Time.deltaTime;
                }
            }
        
    }
}
