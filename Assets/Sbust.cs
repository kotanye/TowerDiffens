using System;
using UnityEngine;
[CreateAssetMenu()]
public class Sbust : ScriptableObject
{
    public float playerhealth = 20;
    public float damage = 2;
    public string boostname;
    public int bullets = 1;
    public float speed = 0.5f;
    public float speedrate = 1;
    public enum boostrare { rare ,epic,legendary };
    public boostrare currentRare;
    public GameObject bulletTipe;
}
