using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UP : MonoBehaviour
{
    public ObjectPoolingtest1 obj;
    GameObject go;
    Vector3 trapPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
       
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Traps"))
        {
            
            trapPos.y = Random.Range(7.2f, 6.2f);
            go = obj.ActivatePrefabs();
            go.transform.position = trapPos;
        }
    }
    public void OnTriggerExit2D()
    {
        Invoke("Exit", 0.2f);
    }

    
    public void Exit(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Traps"))
        {
            obj.DeActivatePrefabs(collision.gameObject);
        }
    }
}
