using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreDisplay;
    public int pointsPerCollect = 25;
    public int lossPerHit = 50;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Food"))
        {
            score += pointsPerCollect;
            Destroy(other.gameObject);
            UpdateScoreDisplay();

        }
        else if (other.CompareTag("Obstacle"))
        {
            score -= lossPerHit;
            Destroy(other.gameObject);
            UpdateScoreDisplay();
        }

    }
    public void UpdateScoreDisplay()
    {
        scoreDisplay.text = "Score: " + score;
    }
}
