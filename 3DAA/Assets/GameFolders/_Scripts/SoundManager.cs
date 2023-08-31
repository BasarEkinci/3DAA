using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }
    
    private AudioSource audioSource;
    [SerializeField] AudioClip stuckSoundEffect;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void PlaySoundEffect()
    {
        audioSource.PlayOneShot(stuckSoundEffect);
    }
}
