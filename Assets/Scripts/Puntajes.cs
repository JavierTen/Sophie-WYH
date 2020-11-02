using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntajes : MonoBehaviour
{
    // Start is called before the first frame update
    public Text HS;
    public Text S;
    public Text NWS;
    public AudioClip win;
    public AudioClip lose;
    AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        HS.text = DatosGlobales.HS.ToString();
        S.text = DatosGlobales.S.ToString();
        if (DatosGlobales.S >= DatosGlobales.HS)
        {
            NWS.text = "NEW";
            audioSource.PlayOneShot(win);
        }else{
            audioSource.PlayOneShot(lose);
        }

    }
    

}
