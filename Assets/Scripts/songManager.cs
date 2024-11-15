using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;
using UnityEngine.Networking;
using System.IO;
using System;

public class songManager : MonoBehaviour
{
    public static songManager Instance;
    public AudioSource audioSource;
    public ScoreController scoreController;
    public float songDelay; //seconds
    public double MoE;
    public int inputDelayms;
    public Lane[] lanes;
    public string fileLocation;
    public float noteTime;
    public float noteSpawnX;
    public float noteTapX;
    public float noteDespawnX
    {
        get
        {
            return noteTapX - (noteSpawnX - noteTapX);
        }
    }
    public int totalNoteCount;

    public static MidiFile midiFile;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        ReadFromFile();

        scoreController = FindObjectOfType<ScoreController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!audioSource.isPlaying)
        {
            scoreController.ShowScoreScreen();
        }
    }
    private void ReadFromFile()
    {
        midiFile = MidiFile.Read(Application.streamingAssetsPath + "/" + fileLocation);
        GetDataFromMidi();
    }

    public void GetDataFromMidi()
    {
        var notes = midiFile.GetNotes();
        var array = new Melanchall.DryWetMidi.Interaction.Note[notes.Count];
        notes.CopyTo(array, 0);
        totalNoteCount = array.Length;

        foreach (var lane in lanes)
        {
            lane.SetTimeStamps(array);
        }
        Invoke(nameof(StartSong), songDelay);
    }

    public void StartSong()
    {
        audioSource.Play();
    }

    public static double GetAudioSourceTime()
    {
        return (double) Instance.audioSource.timeSamples / Instance.audioSource.clip.frequency;
    }
}
