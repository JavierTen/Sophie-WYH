using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusAleatorio : MonoBehaviour
{
    public GameObject Virus;
    
    GameObject virus;
    float tiempodecreacion = 1f, RangoCreacion = 2.8f;
    float timerC = 0f;
    // Start is called before the first frame update
    void Update() {
        if(DatosGlobales.TC > timerC ){
            timerC = DatosGlobales.TC;
            InvokeRepeating("Creando", 0.0f, tiempodecreacion-timerC);
        }
        
    }

    public void Creando()
    {
        Vector3 SpawnPosition = new Vector3(0, 0, 0);
        SpawnPosition = this.transform.position + Random.onUnitSphere * RangoCreacion;
        SpawnPosition = new Vector3(SpawnPosition.x, this.transform.position.y, 0);

        virus = Instantiate (Virus, SpawnPosition, Quaternion.identity);

    }
}
