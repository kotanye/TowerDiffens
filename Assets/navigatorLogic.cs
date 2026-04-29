using UnityEngine;

public class navigatorLogic : MonoBehaviour
{
    public enum dirrection { left, right, up, down };
    public dirrection dir = dirrection.right;
    public float speed = 5;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D enemy)
    {
        if (enemy.tag == "enemy")
        {
            if (dir == dirrection.right)
            {
                enemy.GetComponent<Rigidbody2D>().linearVelocity = Vector2.right * speed;
            }
            if (dir == dirrection.up)
            {
                enemy.GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * speed;
            }
            if (dir == dirrection.down)
            {
                enemy.GetComponent<Rigidbody2D>().linearVelocity = Vector2.down * speed;

            }
            if (dir == dirrection.left)
            {
                enemy.GetComponent<Rigidbody2D>().linearVelocity = Vector2.left * speed;
            }
        }
        
    }
}
