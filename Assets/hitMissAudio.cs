using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitMissAudio : MonoBehaviour

{
    public static hitMissAudio Instance;
    public AudioSource hitSFX;
    public AudioSource missSFX;
    void Start()
    {
        Instance = this;
    }
    public static void Hit()
    {
        Instance.hitSFX.Play();
    }
    public static void Miss()
    {
        Instance.missSFX.Play();
    }
    private void Update()
    {

    }
}

