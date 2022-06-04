using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerController : MonoBehaviour
{
    public float timeValue;
    public TextMeshProUGUI displayedTime;
    [SerializeField] GameObject gameOver;

    void Update()
    {
        updateTime();
    }

    void updateTime()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
        timeDisplay(timeValue);
        
    }
    void timeDisplay(float timeToDisplay)
    {
      
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
            gameOver.GetComponent<GameOverHandler>().trigger();
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        displayedTime.text = string.Format("{0:00}:{1:00}", minutes, seconds);

      
    }
}
