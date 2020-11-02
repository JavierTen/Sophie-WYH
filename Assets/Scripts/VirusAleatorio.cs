using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusAleatorio : MonoBehaviour
{
    public GameObject Virus;
    
    GameObject virus;
    public float tiempodecreacion = 4f, RangoCreacion = 2f;
    public float maxTIme = 1;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Creando", 0.0f, tiempodecreacion);
    }

    public void Creando()
    {
        Vector3 SpawnPosition = new Vector3(0, 0, 0);
        SpawnPosition = this.transform.position + Random.onUnitSphere * RangoCreacion;
        SpawnPosition = new Vector3(SpawnPosition.x, this.transform.position.y, 0);

        virus = Instantiate (Virus, SpawnPosition, Quaternion.identity);

    }
}
