using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollw : MonoBehaviour
{
    public Transform cam, player;
    Vector2 camPos, thisPos, finalPos;
    // Start is called before the fir
    //
    // st frame update
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      
            camPos = new Vector2(cam.position.x, cam.position.y);
            thisPos = new Vector2(player.position.x, player.position.y);
            finalPos = Vector3.Lerp(camPos, thisPos, 0.5f);
            cam.position = new Vector3(finalPos.x, finalPos.y,-10);
    }
    
}
