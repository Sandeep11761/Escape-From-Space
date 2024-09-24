using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPos : MonoBehaviour
{
    public ObjectPoolingtest1 obj;
    Vector3 trapPos;
    GameObject go;
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
        if (collision.gameObject.CompareTag("Traps"))
        {

            trapPos.y += 7;
            go = obj.ActivatePrefabs();
            go.transform.position = trapPos;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            obj.DeActivatePrefabs(collision.gameObject);
        }

    }
   

}
