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
    public int maxScore = 0;
    public bool scorePanelDisabledOnLoad = false;

    void Update()
    {
        if(scorePanelDisabledOnLoad == false)
        {
            songManager = FindObjectOfType<songManager>();
            scorePanel.SetActive(false);
            scorePanelDisabledOnLoad = true;
        }
        scoreText.text = "Score: " + score;
        streakText.text = "x" + streak + " streak!";
    }

    public void ShowScoreScreen()
    {
        maxScore = songManager.maxScore;
        endScoreText.text = "Score: " + score;
        scorePanel.SetActive(true);
    }

    public int CalculateMaxScore(int totalNoteCount)
    {
        for(int i = 0; i < totalNoteCount; i++)
        {
            maxScore += (i+1)*100;
        }
        return maxScore;
    }
}
