using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
   
    public float moveSpeed = 1f;
    Rigidbody2D rb;
    public static Player instans;
   
    public float playerhealth = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        instans = this;
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    
    public void GetDammage(float dammage)
    {
        playerhealth -= dammage;    
        if (playerhealth <= 0)
        {
            death();
        }
        
    }
    public void death()
    {
        timer.instants.SaveRecord();

        SceneManager.LoadScene(1);
       
       
    }
}
