using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float VelocidadCorriendo = 9f;

    public float stamina = 100f;
    public float StaminaMax = 100f;

    public float GastoDeStamina = 10f;
    public float RegenDeStamina = 5f;
    public float CooldownDeStamina = 2f;

    private float VelocidadActual;
    private float staminaCooldown;

    void Start()
    {
        VelocidadActual = moveSpeed;
    }
    void Update()
    {
        
        float moveX = Input.GetAxis("Horizontal"); 
        float moveZ = Input.GetAxis("Vertical");    

        Vector3 move = new Vector3(moveX, 0, moveZ) * moveSpeed * Time.deltaTime;

        transform.Translate(move);


        if (Input.GetKey(KeyCode.LeftShift) && stamina > 0)
        {
            VelocidadActual = VelocidadCorriendo;
            stamina -= GastoDeStamina * Time.deltaTime;
            staminaCooldown = CooldownDeStamina;
        }

        else
        {
            VelocidadActual = moveSpeed;
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
}
