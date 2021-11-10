using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource SolarSystemSound;

    void Start()
    {
        SolarSystemSound = GetComponent<AudioSource>();
        SolarSystemSound.PlayDelayed(1f); // That will play the sound when the game starts ;
    }

    // Update is called once per frame
    void Update()
    {
       
        SolarSystemSound.volume = 0.3f;


    }
}
