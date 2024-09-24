    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolingtest1 : MonoBehaviour
{
    public GameObject traps;
    List<GameObject> listOfPrefabs = new List<GameObject>();
    GameObject go;
    void Start()
    {
        for (int i=0;i<10;i++)
        {
           go= Instantiate(traps);
            go.SetActive(false);
            listOfPrefabs.Add(go);
        }
    }
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
    public void DeActivatePrefabs(GameObject go)
    {
        go.SetActive(false);
    }
}
