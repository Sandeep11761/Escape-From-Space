using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rb;
    float x, y;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(x*speed, y*speed);
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Traps"))
        {
            Debug.Log("Player Dashed To Trap");
            Destroy(gameObject);
        }    
    }

}
