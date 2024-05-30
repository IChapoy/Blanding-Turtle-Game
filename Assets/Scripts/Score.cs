using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    public int pointsPerCollect = 25;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Food")) {
            score += pointsPerCollect;
            Destroy(other.gameObject);
            UpdateScoreDisplay();
        }
        else if (other.CompareTag("Obstacle")) {
            score -= pointsPerCollect;
            Destroy(other.gameObject);
            UpdateScoreDisplay();
        }
    }

    public TextMeshProUGUI ScoreDisplay;

    public void UpdateScoreDisplay()
    {
        ScoreDisplay.text = "Score: " + score;
    }
}
