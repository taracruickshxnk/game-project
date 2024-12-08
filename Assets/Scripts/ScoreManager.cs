using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        // reset the counter for current points
        scoreText.text = score.ToString() + " POINTS";
    }
}
