using Melanchall.DryWetMidi.Interaction;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Lane : MonoBehaviour
{
    public Melanchall.DryWetMidi.MusicTheory.NoteName noteRestriction;
    public KeyCode input;
    public GameObject notePrefab;
    List<Note> notes = new List<Note>();
    public List<double> timeStamps = new List<double>();

    int spawnIndex = 0;
    int inputIndex = 0;

    ScoreController scoreController;

    // Start is called before the first frame update
    void Start()
    {
        scoreController = FindObjectOfType<ScoreController>();
    }

    public void SetTimeStamps(Melanchall.DryWetMidi.Interaction.Note[] array)
    {
        foreach(var note in array)
        {

            if (note.NoteName == noteRestriction)
            {

                var metricTimeSpan = TimeConverter.ConvertTo<MetricTimeSpan>(note.Time, songManager.midiFile.GetTempoMap());
                timeStamps.Add((double)metricTimeSpan.Minutes * 60f + metricTimeSpan.Seconds + (double)metricTimeSpan.Milliseconds / 1000f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnIndex < timeStamps.Count)
        {
            if (songManager.GetAudioSourceTime() >= timeStamps[spawnIndex] - songManager.Instance.noteTime)
            {
                var note = Instantiate(notePrefab, transform);
                notes.Add(note.GetComponent<Note>());
                note.GetComponent<Note>().assignedTime = (float)timeStamps[spawnIndex];
                spawnIndex++;
            }
        }

        if (inputIndex < timeStamps.Count)
        {
            double timeStamp = timeStamps[inputIndex];
            double MoE = songManager.Instance.MoE;
            double audioTime = songManager.GetAudioSourceTime() - (songManager.Instance.inputDelayms / 1000.0);

            if (Input.GetKeyDown(input))
            {
                if (Math.Abs(audioTime - timeStamp) < MoE)
                {
                    hitMissAudio.Hit();
                    print($"Hit on {inputIndex} note");
                    Destroy(notes[inputIndex].gameObject);
                    inputIndex++;
                    scoreController.streak++;
                    scoreController.score = scoreController.score + 100*scoreController.streak;
                }
                else
                {
                    hitMissAudio.Miss();
                    print($"Hit inaccurate on {inputIndex} note with {Math.Abs(audioTime - timeStamp)} delay");
                    scoreController.streak = 0;
                }
            }
            if (timeStamp + MoE <= audioTime)
            {
                //print($"Missed {inputIndex} note");
                hitMissAudio.Miss();
                inputIndex++;
                scoreController.streak = 0;
            }

        }
    }
}
