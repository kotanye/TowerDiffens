using System.Collections.Generic;
using UnityEngine;

public class Enamymeneger : MonoBehaviour
{
    public List<GameObject> spawnedEnamy = new List<GameObject>();
    public static Enamymeneger instans;
    public float slojnost;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instans = this;
    }

    // Update is called once per frame
    void Update()
    {
        slojnost = (int)Time.timeSinceLevelLoad;
    }
}
