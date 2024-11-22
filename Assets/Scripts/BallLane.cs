using Melanchall.DryWetMidi.Interaction;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

    
public class BallLane : MonoBehaviour
{
    public Melanchall.DryWetMidi.MusicTheory.NoteName noteRestriction;
    public GameObject ballPrefab;
    List<Ball> balls = new List<Ball>();
    public List<double> timeStamps = new List<double>();
    int spawnIndex = 0;
    int inputIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
    }
    public void SetTimeStamps(Melanchall.DryWetMidi.Interaction.Note[] array)
    {
        foreach (var ball in array)
        {
            if (ball.NoteName == noteRestriction)
            {
                var metricTimeSpan = TimeConverter.ConvertTo<MetricTimeSpan>(ball.Time, songManager.midiFile.GetTempoMap());
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
                var ball = Instantiate(ballPrefab, transform);
                balls.Add(ball.GetComponent<Ball>());
                ball.GetComponent<Ball>().assignedTime = (float)timeStamps[spawnIndex];
                spawnIndex++;
            }
        }
    }
}