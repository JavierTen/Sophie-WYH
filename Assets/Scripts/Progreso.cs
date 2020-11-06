using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progreso : MonoBehaviour
{
    float progreso = 0;
    public AudioClip pop;
    public AudioClip NextLevel;
    AudioSource audioSource;
    int s = 0;
    int level = 0;

    public Image barraProgreso;
    public GameObject NL;
    public GameObject virus;

    public Text textoP;

    public Text textoS;
    // Start is called before the first frame update
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        DatosGlobales.TC = 0.001f;
    }

    // Update is called once per frame
    void Update()
    {
        progreso = Mathf.Clamp(progreso, 0, 100);
        barraProgreso.fillAmount = progreso / 100;
        textoP.text = progreso.ToString() + "%";
        if (progreso == 100)
        {
            DatosGlobales.TC += 0.001f;
            audioSource.PlayOneShot(NextLevel);
            NL.SetActive(true);
            progreso = 0;
            level += 1;
            if((level % 2) == 0){
                DatosGlobales.V += 20;
            }

        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        progreso += 2;
        s += 10;
        DatosGlobales.S = s;
        textoS.text = DatosGlobales.S.ToString();
        if (collision.gameObject.tag == "Virus")
        {
            audioSource.PlayOneShot(pop);
            Destroy(collision.gameObject);
        }
    }
}
