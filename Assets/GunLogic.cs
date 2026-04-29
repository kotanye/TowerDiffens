using UnityEngine;


using System.Collections;
using UnityEngine.UIElements;

public class GunLogic : MonoBehaviour
{
    public GameObject bullet;
    public float speedrate = 1;
    public float speed = 5;
    public float damage = 5;
    public int BulletCount;
    public float interval;
    public static GunLogic instance;
    Vector2 possition;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
        StartCoroutine(spawnbulet());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spawnbulet()
    {
        while (true)
        {

            interval = speedrate / BulletCount;
            if  (BulletCount == 1)
            { 
                interval = 0;
            }
            yield return new WaitForSeconds(speedrate);
           
            for (int i = 0; i < BulletCount; i++)
            {
                yield return new WaitForSeconds(interval);
                GameObject spawnedBulled = Instantiate(bullet, transform.position, new Quaternion(0, 0, 0, 0));
                Transform child = spawnedBulled.transform.Find("osnova");
                //print(child.name);
                Transform[] allChildObjects = child.gameObject.GetComponentsInChildren<Transform>();
                print(allChildObjects[0].name);
                Vector3 mouse = Input.mousePosition;
                //mouse.z = 10f;
                //разобраться с градусами тройные пули

                Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(mouse);

                Vector2 direction = mouseWorld - transform.position;

                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

                child.transform.rotation = Quaternion.Euler(0, 0, -1 * angle);

                Rigidbody2D rb = child.GetComponent<Rigidbody2D>();
                possition = Input.mousePosition;

                possition = Camera.main.ScreenToWorldPoint(possition).normalized;
                rb.linearVelocity = possition.normalized * speed;
                foreach (Transform obj in allChildObjects)
                {
                    if (obj != child)
                    {
                        obj.GetComponent<bulletLOgic>().speed = speed;
                        obj.GetComponent<bulletLOgic>().damage = damage;
                        obj.GetComponent<Transform>().localScale *= damage / 10;
                    }
                   
                }
                    
            }
                
            
        }
    }
}
