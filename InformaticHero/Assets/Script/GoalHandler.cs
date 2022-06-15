using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoalHandler : MonoBehaviour
{
    public GameObject angkaUtama;
    public GameObject angkaUtama2;
    public GameObject gameWin;
    public TextMeshProUGUI angkaTujuan;
    int goalNumber,answerNumber,answerNumber2;
    
    void Start()
    {
       angkaTujuan.text = "" + angkaUtama.GetComponent<OnDropAngkaUtama>().angkaTujuan; 
    }

    public void isAnswerCorrect(){

        answerNumber = angkaUtama.GetComponent<OnDropAngkaUtama>().angkaUtama;
        if(angkaUtama2 != null){
            answerNumber2 = angkaUtama2.GetComponent<OnDropAngkaUtama>().angkaUtama;
        }
        goalNumber = angkaUtama.GetComponent<OnDropAngkaUtama>().angkaTujuan;

        if(angkaUtama2 != null){
            if(answerNumber == goalNumber && answerNumber2 == goalNumber){
                gameWin.SetActive(true);
            }
        }
        else{
            if(answerNumber == goalNumber){
                gameWin.SetActive(true);
            }
        }
    }
}
