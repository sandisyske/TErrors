using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("----------source--------")]
    [SerializeField] AudioSource MusicSource;
    [SerializeField] AudioSource SFXSource;
    [Header("----------clips--------")]
    public AudioClip background;
    public AudioClip shot;
    public AudioClip summon;
    public AudioClip playerhit;
}
