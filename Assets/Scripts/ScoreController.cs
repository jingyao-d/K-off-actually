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
    [SerializeField] GameObject starOne;
    [SerializeField] GameObject starTwo;
    [SerializeField] GameObject starThree;
    [SerializeField] TextMeshProUGUI endScoreText;
    public int score = 0;
    public int streak = 0;
    public int maxScore = 0;
    [SerializeField] private float oneStarCutoff;
    [SerializeField] private float twoStarCutoff;
    [SerializeField] private float threeStarCutoff;

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
        maxScore = songManager.maxScore;
        endScoreText.text = "Score: " + score;
        scorePanel.SetActive(true);

        starOne.SetActive(false);
        starTwo.SetActive(false);
        starThree.SetActive(false);

        if(score > maxScore * threeStarCutoff)
        {
            starOne.SetActive(true);
            starTwo.SetActive(true);
            starThree.SetActive(true);
        }
        else if(score > maxScore * twoStarCutoff)
        {
            starOne.SetActive(true);
            starTwo.SetActive(true);
        }
        else if(score > maxScore * oneStarCutoff)
        {
            starOne.SetActive(true);
        }
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
