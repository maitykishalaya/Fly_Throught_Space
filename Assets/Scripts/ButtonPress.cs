using System.Collections;
using System;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    //public Sound sound;
    public AudioClip clip;
    [HideInInspector]
    public AudioSource source;
    public static ButtonPress instance;

    public void buttonPress()
    {
        source.Play();
        DontDestroyOnLoad(gameObject);
    }

    private void Awake()
    {

        
        source = gameObject.AddComponent<AudioSource>();
       source.clip = clip;
        
    }

}
