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
        SceneManager.LoadScene("Stage2");
    }

}
