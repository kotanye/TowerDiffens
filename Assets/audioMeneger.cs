using System;
using UnityEngine;
using UnityEngine.Audio;

public class audioMeneger : MonoBehaviour
{
    public static audioMeneger Instance;
    public AudioSource enamySound;
    public AudioSource musicSound;
    public float MasterValume;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instance = this;
    }

    private void Awake()
    {
        MasterValume = PlayerPrefs.GetFloat("Valume");
        enamySound.volume*=MasterValume;
        musicSound.volume*=MasterValume;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlaySound(AudioResource newSoumd)
    {
        GetComponent<AudioSource>().resource = newSoumd;
        GetComponent<AudioSource>().Play();
    }
    public void PlayMusic(AudioResource newMusic)
    {
        musicSound.resource = newMusic;
        musicSound.Play();
    }
}