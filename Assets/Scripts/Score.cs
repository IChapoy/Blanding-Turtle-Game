using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    public int pointsPerCollect = 25;
    public AudioSource crunch1;
    public AudioSource crunch2;



    // Start is called before the first frame update
    void Start()
    {
        crunch1 = this.gameObject.GetComponent<AudioSource>();
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
            if (other.gameObject.name == "snail shell_0(Clone)" )
            {
                crunch2.Play();
            } else
            {
                crunch1.Play();

            }
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