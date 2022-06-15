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
    [SerializeField] GameObject gameWin;
    [SerializeField] GameObject pause;

    void Update()
    {
        updateTime();
    }

    void updateTime()
    {
        if(gameWin.activeSelf == false && gameOver.activeSelf == false && pause.activeSelf == false){
            timeValue -= Time.deltaTime;
            displayedTime.text = "" + timeValue;
            if(timeValue <= 0){
                gameOver.SetActive(true);
            }
        }
        timeDisplay(timeValue);
    }
    void timeDisplay(float timeToDisplay)
    {
      
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        displayedTime.text = string.Format("{0:00}:{1:00}", minutes, seconds);

      
    }
}
