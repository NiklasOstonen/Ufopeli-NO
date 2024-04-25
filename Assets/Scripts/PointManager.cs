using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    public static event Action OnPlayerWin;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
    }
    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }

}
