using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
    float vida = 100;
    public Image barraVida;
  
    // Update is called once per frame
    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);
        barraVida.fillAmount = vida / 100;
        if (vida == 0)
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
        vida -= 10;
        if (collision.gameObject.tag == "Virus")
        {
            Destroy(collision.gameObject);
        }
    }
}
