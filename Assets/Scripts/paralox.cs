using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paralox : MonoBehaviour
{
    public Transform bg;
    float effect = 25.7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Paralox Effect");
            bg.position = new Vector2(0, transform.position.y+effect);
        }
    }
}
