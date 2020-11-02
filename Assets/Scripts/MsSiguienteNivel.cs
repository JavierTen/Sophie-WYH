using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MsSiguienteNivel : MonoBehaviour
{
    
    public GameObject NL;
     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Virus")
        {
            NL.SetActive(false);
        }
    }
}
