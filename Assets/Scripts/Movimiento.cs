using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public GameObject efecto;
    public bool isPlayer1;
    public float speed;
    private float movement;
    public Rigidbody2D rb;


    // Update is called once per frame
   void Start() {
        Instantiate(efecto, new Vector3(this.transform.position.x,this.transform.position.y, this.transform.position.z),transform.rotation);
    }
    void Update()
    {
        if (isPlayer1){
            movement = Input.GetAxisRaw("Horizontal");
        }
        rb.velocity = new Vector2(rb.velocity.y, movement * speed);
        
        
    }
}
