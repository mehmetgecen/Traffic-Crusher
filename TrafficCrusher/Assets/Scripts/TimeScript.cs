using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeScript : MonoBehaviour
{

    public float timeValue;
    public float elapsedTime;
    public float remainingTime;
    public float score;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreText2;
    public TextMeshProUGUI timeText;


    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
            elapsedTime += Time.deltaTime;
        }

        else
        {
            GameEssentials.isGameOver = true;
        }

        timeText.text = "Remaining Time: " + Mathf.Floor(timeValue) ;

    }

    public void CalculateScore()
    {
        score += timeValue * 3;
        scoreText.text = "Score: " + Mathf.Floor(score);
        scoreText2.text = Mathf.Floor(score).ToString();
    }

}
