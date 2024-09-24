using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject player;
    float actualPos;
    float xPos;
    public float speed;
    float fast = 3;
    // Start is called before the first frame update
    void Start()
    {
        actualPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
       
        actualPos += Time.deltaTime;
        player.transform.position = new Vector3(actualPos + xPos*speed, transform.position.y,0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale = -1*fast;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.gravityScale = 1*fast;
        }
    }
    public void PlayerJump()
    {

    }
}
