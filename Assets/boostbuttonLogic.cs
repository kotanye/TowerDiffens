using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class boostbuttonLogic : MonoBehaviour
{
    public Sbust Currentboost;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        Currentboost = BoostMeneger.instance.Getrandboost();
        GetComponentInChildren<TMP_Text>().text = Currentboost.boostname;
        changebuttoncolor();


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Onclick()
    {
        BoostMeneger.instance.ApplyBoost(Currentboost);
        utils.SetPause(false);
        BoostMeneger.instance.boostImage.SetActive(false);

    }
    public void changebuttoncolor()
    {
        if (Currentboost.currentRare == Sbust.boostrare.rare)
        {
            //GetComponent<Button>().colors.normalColor = Color.green;
            GetComponent<Image>().color = Color.green;
        }

        if (Currentboost.currentRare == Sbust.boostrare.epic)
        {
            //GetComponent<Button>().colors.normalColor = Color.green;
            GetComponent<Image>().color = Color.magenta;
        }

        if (Currentboost.currentRare == Sbust.boostrare.legendary)
        {
            //GetComponent<Button>().colors.normalColor = Color.green;
            GetComponent<Image>().color = Color.yellow;
        }
    }
}
