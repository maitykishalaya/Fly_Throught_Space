using System.Collections;
using System;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static audioManager instance;    // An array of type 'Sound' is created namely 'sounds'

    private void Start()
    {
        playSound("Theme");
        DontDestroyOnLoad(gameObject);
        
    }

    private void Awake()
    {

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        
        foreach (Sound s in sounds )                                             // At awake load the sounds and its parameters from 'Sound' script
        {
            s.source = gameObject.AddComponent<AudioSource>();                     // Add the sound to the current game object
            s.source.clip = s.audioClip;                                           // Add the clip
            s.source.volume = s.volume;                                            // Add the volume
            s.source.pitch = s.pitch;                                              //Add the pitch  
        }       
    }

    public void playSound(String name)                                            // A function that is to be called to invoke the sounds 
    {                                                                            // of that name when triggered in other scripts
    Sound s = Array.Find(sounds, Sound => Sound.name == name);               // 'using System' namespace is used for this. This line finds the Sound type 
    s.source.Play();   //play the sound                                      //from 'sounds' array in Sound where 'Sound.name'=='name' 
           
    }

}
