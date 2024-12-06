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
    public BallLane[] bLanes;
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
    public int maxScore;
    public static MidiFile midiFile;
    private bool songStarted = false;
    // Start is called before the first frame update

    void Start()
    {
        scoreController = FindObjectOfType<ScoreController>();

        Instance = this;
        if (Application.streamingAssetsPath.StartsWith("http://") || Application.streamingAssetsPath.StartsWith("https://"))
        {
            StartCoroutine(ReadFromWebsite());
        }
        else
        {
            ReadFromFile();
        }
    }

    private IEnumerator ReadFromWebsite()
    {
        using (UnityWebRequest www = UnityWebRequest.Get(Application.streamingAssetsPath + "/" + fileLocation))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.LogError(www.error);
            }
            else
            {
                byte[] results = www.downloadHandler.data;
                using (var stream = new MemoryStream(results))
                {
                    midiFile = MidiFile.Read(stream);
                    GetDataFromMidi();
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(!audioSource.isPlaying && songStarted == true)
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
        maxScore = scoreController.CalculateMaxScore(array.Length);

        foreach (var lane in lanes)
        {
            lane.SetTimeStamps(array);
        }
        foreach (var lane in bLanes)
        {
            lane.SetTimeStamps(array);
        }
        Invoke(nameof(StartSong), songDelay);
    }

    public void StartSong()
    {
        audioSource.Play();
        songStarted = true;
    }

    public static double GetAudioSourceTime()
    {
        return (double) Instance.audioSource.timeSamples / Instance.audioSource.clip.frequency;
    }
}
