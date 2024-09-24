using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform wall;
     float x = -74.59f;
    public Rigidbody2D rb;
    public static GameManager instance;
     float speed;
   
    
    // Start is called before the first frame update
    void Start()
    {
        if(instance==null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

       /*for( i=0;i<10;i++)
        {
             go=Instantiate(trap);
            go.SetActive(false);
            listOfPrefabs.Add(go);

        }*/
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("player");
            wall.position = new Vector2(0, transform.position.y + x);
            
        }
    }
/*
  public GameObject ActivatePrefabs()
    {
        foreach(GameObject go in listOfPrefabs)
        {
            if(go.activeInHierarchy==false)
            {
                go.SetActive(true);
                return go;
            }
        }
        return null;
    }
    public void DeActivate(GameObject go)
    {
        go.SetActive(false);
    }*/
}
