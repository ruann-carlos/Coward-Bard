using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMananger : MonoBehaviour
{

    [SerializeField] private AudioClip RunAudio;
    [SerializeField] private AudioClip DeathAudio;
    private AudioSource audSource;


    private void OnEnable()
    {
        HeroLife.DeathAction += SetAudioDeath;
    }

    private void OnDisable()
    {
        HeroLife.DeathAction -= SetAudioDeath;
    }
    private void Start()
    {
        audSource = gameObject.GetComponent<AudioSource>();
    }

    private void SetAudioDeath()
    {
        audSource.clip = DeathAudio;
        audSource.Play();
    }

}
