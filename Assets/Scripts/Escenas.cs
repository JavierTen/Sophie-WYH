using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escenas : MonoBehaviour
{
    // Start is called before the first frame update

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void Juego()
    {
        DatosGlobales.S = 0;
        SceneManager.LoadScene("Juego");
    }

    public void IniciarJuego()
    {
        DatosGlobales.HS = 0;
        SceneManager.LoadScene("Juego");
    }



}
