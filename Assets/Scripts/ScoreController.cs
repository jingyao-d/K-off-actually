using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private songManager songManager;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI streakText;
    [SerializeField] GameObject scorePanel;
    [SerializeField] TextMeshProUGUI endScoreText;
    public int score = 0;
    public int streak = 0;
    private int maxScore = 0;

    void Start()
    {
        songManager = FindObjectOfType<songManager>();
        scorePanel.SetActive(false);
    }
    void Update()
    {
        scoreText.text = "Score: " + score;
        streakText.text = "x" + streak + " streak!";
    }

    public void ShowScoreScreen()
    {
        CalculateMaxScore();
        maxScore = songManager.totalNoteCount;
        endScoreText.text = "Score: " + score;
        scorePanel.SetActive(true);
    }

    private void CalculateMaxScore()
    {
        for(int i = 0; i < songManager.totalNoteCount; i++)
        {
            maxScore += (i+1)*100;
        }
    }
}
