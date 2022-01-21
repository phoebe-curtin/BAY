using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [Header("AUDIO SOURCES")]
    public AudioSource oceanAudio;
    public AudioSource reverseOceanAudio;

    Inverter inverter;

    void Awake()
    {
        inverter = GameObject.FindWithTag("Inverter").GetComponent<Inverter>();
    }

    void Update()
    {
        if (inverter.isInverted && !reverseOceanAudio.isPlaying)
        {
            oceanAudio.Stop();
            reverseOceanAudio.Play();
        }
        else if (!inverter.isInverted && !oceanAudio.isPlaying)
        {
            reverseOceanAudio.Stop();
            oceanAudio.Play();
        }
    }
}
