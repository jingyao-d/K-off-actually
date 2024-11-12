using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI streakText;
    public int score = 0;
    public int streak = 0;

    void Update()
    {
        scoreText.text = "Score: " + score;
        streakText.text = "x" + streak + " streak!";
    }
}
