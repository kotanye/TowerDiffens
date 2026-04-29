using UnityEngine;
using UnityEngine.EventSystems;


public class ChestLogic : MonoBehaviour , IPointerClickHandler 

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPlayerContact()
    {
        BoostMeneger.instance.refreshboosts();
        BoostMeneger.instance.boostImage.SetActive(true);
        utils.SetPause(true);
        Destroy(gameObject);

    }

    public void OnPointerClick(PointerEventData eventData)
    {
       OnPlayerContact();
    }
}