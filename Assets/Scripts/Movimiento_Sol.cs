using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Sol : MonoBehaviour

{
    [Range(0.0f, 24f)] public float Hora = 12;
    public Transform Sol;
    public Transform Luna;
    public float velocidadTransicion = 1.0f; // Velocidad de la transición día/noche

    private float SolX;

    private float LunaX;

    private void Update()
    {
        Hora += Time.deltaTime * velocidadTransicion;
        if (Hora >= 24f)
        {
            Hora = 0f; // Reinicia el ciclo al llegar a 24 horas
        }
        RotacionSol();
    }

    void RotacionSol()
    {
        SolX = 15 * Hora;
        Sol.localEulerAngles = new Vector3(SolX, 0, 0);
        LunaX = 15 * Hora;
        Luna.localEulerAngles = new Vector3(LunaX, 0, 0);
    }
}
