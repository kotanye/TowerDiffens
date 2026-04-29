using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI;
public class BoostMeneger : MonoBehaviour
{
    public static BoostMeneger instance;
    public GameObject boostImage;
    public List<Sbust> boostList = new List<Sbust>();
    public GameObject button;
    public GameObject button1;
    public GameObject button2;

    public List<Sbust> boostRareList = new List<Sbust>();
    public List<Sbust> boostEpicList = new List<Sbust>();
    public List<Sbust> boostLegendaryList = new List<Sbust>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
        foreach (var item in boostList)
        {
            if (item.currentRare == Sbust.boostrare.rare)
            {
                boostRareList.Add(item);
            }
            if (item.currentRare == Sbust.boostrare.epic)
            {
                boostEpicList.Add(item);
            }
            if (item.currentRare == Sbust.boostrare.legendary)
            {
                boostLegendaryList.Add(item);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ApplyBoost(Sbust sbust)
    {
        Player.instans.playerhealth += sbust.playerhealth;
        GunLogic.instance.BulletCount += sbust.bullets;
        GunLogic.instance.damage += sbust.damage;
        GunLogic.instance.speed += sbust.speed;
       if (GunLogic.instance.speedrate + sbust.speedrate< 0.1f)
        {
            GunLogic.instance.speedrate = 0.1f;
        }
       else
        {
            GunLogic.instance.speed += sbust.speed;
        }
        
    }
    public Sbust Getrandboost()
    {
        Sbust.boostrare currentRare = utils.GetBoostrare();
        if (currentRare == Sbust.boostrare.rare)
        {
            return boostRareList[Random.Range(0, boostRareList.Count)];
        }
        if (currentRare == Sbust.boostrare.epic)
        {
            return boostEpicList[Random.Range(0, boostEpicList.Count)];
        }
        if (currentRare == Sbust.boostrare.legendary)
        {
            return boostLegendaryList[Random.Range(0, boostLegendaryList.Count)];
        }
        return boostList[Random.Range(0, boostList.Count)];
    }
    public void refreshboosts()
    {
        button.GetComponent<boostbuttonLogic>().Start();
        button1.GetComponent<boostbuttonLogic>().Start();
        button2.GetComponent<boostbuttonLogic>().Start();
    }
}
