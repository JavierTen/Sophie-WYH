using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntajeHSJuego : MonoBehaviour
{
    // Start is called before the first frame update
     public Text HS;
    void Start()
    {
        HS.text = DatosGlobales.HS.ToString();
    }

    // Update is called once per frame
    
}
