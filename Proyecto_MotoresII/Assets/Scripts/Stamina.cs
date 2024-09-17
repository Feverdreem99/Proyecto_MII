using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stamina : MonoBehaviour
{
    public CharacterController controller;

    public TMP_Text TextoStamina;

    public float VelocidadCaminado = 6f;
    public float VelocidadCorriendo = 9f;
    public float stamina = 100f;
    public float StaminaMax = 100f;
    public float GastoDeStamina = 10f;
    public float RegenDeStamina = 5f;
    public float CooldownDeStamina = 2f;

    private float VelocidadActual;
    private float staminaCooldown;

    Vector3 velocidad;
    public float gravedad = -2.0f;

    public Transform groundCheck;
    public float DistanciaGround = 0.4f;
    public LayerMask MascaraGround;

    private bool isGrounded;

    void Start()
    {
        VelocidadActual = VelocidadCaminado;
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, DistanciaGround, MascaraGround);

       
        if (isGrounded && velocidad.y < 0)
        {
            velocidad.y = 0f; 
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movimiento = transform.right * x + transform.forward * z;

        if (Input.GetKey(KeyCode.LeftShift) && stamina > 0)
        {
            VelocidadActual = VelocidadCorriendo;
            stamina -= GastoDeStamina * Time.deltaTime;
            staminaCooldown = CooldownDeStamina; 
        }
        else
        {
            VelocidadActual = VelocidadCaminado;
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

        stamina = Mathf.Clamp(stamina, 0, StaminaMax);

        controller.Move(movimiento * VelocidadActual * Time.deltaTime);

        if (!isGrounded)
        {
            velocidad.y += gravedad * Time.deltaTime;
        }

        controller.Move(velocidad * Time.deltaTime);
        TextoStamina.text = stamina.ToString();
    }
}


