using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverHandler : MonoBehaviour
{
   
    public void trigger()
    {
        gameObject.SetActive(true);
    }
    public void restartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void homeButton()
    {
        SceneManager.LoadScene("StageSelection");
    }
    public void nextLevelButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
