using UnityEngine;
using TMPro;
public class timer : MonoBehaviour
{
    public TMP_Text TEXT;
    public int seconds;
    public static timer instants;
    public TMP_Text Maxtimetext;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instants = this;
        Maxtimetext.text = PlayerPrefs.GetInt("maxRecord").ToString();
    }
    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        TEXT.text = ((int)Time.timeSinceLevelLoad).ToString();
        seconds = (int)Time.timeSinceLevelLoad;
    }
    public void SaveRecord()
    {
        if (PlayerPrefs.GetInt("maxRecord") < seconds)  
        {
            PlayerPrefs.SetInt("maxRecord",seconds);
        }
    }
}
