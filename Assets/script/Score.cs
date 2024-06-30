using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    public float t = 0;

    private void AddScore(int value)
    {
        score += value;
    }

    private void ResetScore()
    {
        score = 0;
    }

    private void Reload()
    {
        scoreText.text = "Score : " + score;
    }
    
    private void Start()
    {
        ResetScore();
        Reload();
    }
    
    private void Update()
    {
        t -= Time.deltaTime;
        if (!(t <= 0)) return;
        
        AddScore(1);
        Reload();
        t = 1;
    }
}
