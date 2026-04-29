using UnityEngine;
using UnityEngine.Audio;

public class Enamy : MonoBehaviour
{
    public float health;
    public float speed;
    public float damage;
    public enum dirrection { left , right , up , down};
    public dirrection dir = dirrection.right;
    public GameObject chest;
    public float chestchance = 0.05f;
    public AudioResource deathSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if ( dir == dirrection.right )
        {
            GetComponent<Rigidbody2D>().linearVelocity = Vector2.right * speed;
        }
        if ( dir == dirrection.up )
        {
            GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * speed;
        }
        if ( dir == dirrection.down )
        {
            GetComponent<Rigidbody2D>().linearVelocity = Vector2.down * speed;

        }
        if ( dir == dirrection.left )
        {
            GetComponent<Rigidbody2D>().linearVelocity = Vector2.left * speed;
        }
        health *= Enamymeneger.instans.slojnost / 120;
        damage *= Enamymeneger.instans.slojnost / 120;
        chestchance *= Enamymeneger.instans.slojnost / 30;
        gameObject.transform.localScale = new Vector2 ( 0.5f +health / 10,0.5f + health / 10) ;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Dead();
        }
    }
    public void  Dead()
    {
        audioMeneger.Instance.PlaySound(deathSound);
        if (utils.IsLuck(chestchance))
        {
            SpawnChest(transform.position);
        }
        Enamymeneger.instans.spawnedEnamy.Remove(gameObject.transform.parent.gameObject);
        Destroy(gameObject);
    }
    public void GiveDamage()
    {
        Player.instans.GetDammage(damage);
        Dead();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if( collision.gameObject.tag == "Player")
        {
            print("give");
            GiveDamage();
        }
    }
    public void SpawnChest(Vector2 pos)
    {
        Instantiate(chest, pos, Quaternion.identity);
    }
}
