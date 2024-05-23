using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public int score;
    public int pointsPerCollect = 25;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Food"))
        {
            score += pointsPerCollect;
            Destroy(other.gameObject);
            UpdateScoreDisplay();

        }

    }
    public TextMeshProUGUI scoreDisplay;
    public void UpdateScoreDisplay()
    {
        scoreDisplay.text = "Score: " + score;
    }
}
