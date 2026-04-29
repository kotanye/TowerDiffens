using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;


public  static class utils 
{

    public static GameObject ThereEnemy()
    {
        List<GameObject> gameObjects = Enamymeneger.instans.spawnedEnamy;
        Transform plaertransform = Player.instans.transform;
        float raznica = 1000000000;
        GameObject returnedEnemy = null;
        foreach (GameObject obj in gameObjects)
        {
            Transform enemyTransform = obj.GetComponentInChildren<Transform>();
            float x1 = enemyTransform.position.x;
            float y1 = enemyTransform.position.y;
            float x2 = plaertransform.position.x;
            float y2 = plaertransform.position.y;
            float D = math.sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
            if (D < raznica)
            {
                returnedEnemy = obj.transform.GetChild(0).gameObject;
                raznica = D;
            }

        }
        return returnedEnemy;
    }
    public static  bool IsLuck( float luckChance)
    {
        float rundomnumber = UnityEngine.Random.Range(0, 1f);
        return rundomnumber <= luckChance;
    }
    public static void SetPause(bool ispause)
    {
        if (ispause)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
     public static Sbust.boostrare GetBoostrare()
    {
        var RandomNumber = UnityEngine.Random.Range (0f, 1f);
        if (RandomNumber <= 0.1f)
        {
            return Sbust.boostrare.legendary;
        }
        else if (RandomNumber <= 0.4f)
        {
            return Sbust.boostrare.epic;
        }
        else 
        { 
            return Sbust.boostrare.rare;
        }
    }
}
