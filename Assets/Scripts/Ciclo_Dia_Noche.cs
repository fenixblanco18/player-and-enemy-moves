using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciclo_Dia_Noche : MonoBehaviour
{

    public int SunMove = 10;

    
    void Update()
    {
        transform.Rotate(SunMove * Time.deltaTime, 0, 0); 
      
    }
}
