using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject currentenemy;
    public List<GameObject> enamys = new List<GameObject>();
    private int randEnamy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Enamymeneger.instans.spawnedEnamy.Add(Instantiate(currentenemy,transform.position,transform.rotation));
        }
       

    }
}
