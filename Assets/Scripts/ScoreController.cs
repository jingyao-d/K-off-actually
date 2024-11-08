using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private PlayerInputDetection playerInputDetection;

    private void Start()
    {
        playerInputDetection = GetComponent<PlayerInputDetection>();
    }

    void Update()
    {
        scoreText.text = "Score: " + playerInputDetection.score;
    }
}
