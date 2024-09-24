using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerJump : MonoBehaviour
{
    public Rigidbody2D rb;
    float speed;
    Touch tch;
    public Animator rotate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


            if (Input.GetKey(KeyCode.D))
            {

                rb.velocity = new Vector2(7, 0);


            }
            if (Input.GetKey(KeyCode.A))
            {

                rb.velocity = new Vector2(-7, 0);
            }
      

    }
   
    public void OnCollisionEnter2D(Collision2D collision)
    {


       
        if (collision.gameObject.CompareTag("Traps"))
        {
            Debug.Log("Player Dashed to Traps");
            Destroy(gameObject);
        }
        
    }
    public void GameStop()
    {
        Time.timeScale = 0;
    }
    public void GameResume()
    {
        Time.timeScale = 1;
    }
    public void jump()
    {
       
    }
    
}
