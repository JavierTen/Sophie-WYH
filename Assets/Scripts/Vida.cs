using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
   
    public Image barraVida;
    void Start(){
        DatosGlobales.V = 100f;    
    }
    // Update is called once per frame
    void Update()
    {
        DatosGlobales.V = Mathf.Clamp(DatosGlobales.V, 0, 100);
        barraVida.fillAmount = DatosGlobales.V / 100;
        if (DatosGlobales.V == 0)
        {
            
            if (DatosGlobales.S > DatosGlobales.HS)
            {
                
                DatosGlobales.HS = DatosGlobales.S;
            }
            SceneManager.LoadScene("Perdio");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DatosGlobales.V -= 2f;
        if (collision.gameObject.tag == "Virus")
        {
            Destroy(collision.gameObject);
        }
    }
}
