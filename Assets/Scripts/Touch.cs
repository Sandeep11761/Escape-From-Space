using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Touch : MonoBehaviour
{
    public Touch tch;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Input.GetTouch(0);
            Debug.Log("touched");

        }
          


    }
}
