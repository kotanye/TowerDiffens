using UnityEngine;

public class bulletLOgic : MonoBehaviour
{
    public GameObject enemy;
    Rigidbody2D rb;
    Vector2 possition;
    [HideInInspector]
    public float speed =5;
    [HideInInspector]
    public float damage = 5;
    public float kfsmesh= 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemy = utils.ThereEnemy();
        //enemy = enemy.GetComponentInChildren<Transform>().gameObject;
        rb = GetComponent<Rigidbody2D>();
        //possition = ((Vector2)enemy.transform.position -  (Vector2)transform.position).normalized;
        possition = Input.mousePosition;

         possition = Camera.main.ScreenToWorldPoint(possition).normalized;
        //possition = new Vector2(Camera.main.ScreenToWorldPoint(possition).x , Camera.main.ScreenToWorldPoint(possition).y).normalized;
        //rb.linearVelocity = possition.normalized * speed ;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "enemy")
        {
            collision.gameObject.GetComponentInChildren<Enamy>().health -= damage;
            Destroy(gameObject);
            

        }
        
    }
    
}
