using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaloxEffect : MonoBehaviour
{
    public Transform wall;
    float x = 74.59f;
    public Rigidbody2D gravityCheker;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player");
            wall.position = new Vector2(0, transform.position.y + x);
            gravityCheker.gravityScale = -0.8f;
        }
    }
    public void Destroy()
    {
        
    }
}
