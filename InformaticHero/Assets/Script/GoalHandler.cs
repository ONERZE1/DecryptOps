using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoalHandler : MonoBehaviour
{
    public GameObject angkaUtama;
    public GameObject angkaUtama2;
    public TextMeshProUGUI angkaTujuan;
    int goalNumber,answerNumber,answerNumber2;
    
    void Start()
    {
       angkaTujuan.text = "" + angkaUtama.GetComponent<OnDropAngkaUtama>().angkaTujuan; 
    }

    public void isAnswerCorrect(){

        answerNumber = angkaUtama.GetComponent<OnDropAngkaUtama>().angkaUtama;
        answerNumber2 = angkaUtama2.GetComponent<OnDropAngkaUtama>().angkaUtama;
        goalNumber = angkaUtama.GetComponent<OnDropAngkaUtama>().angkaTujuan;

      
        if(answerNumber + answerNumber2 == goalNumber){

            Debug.Log("DAH BENER!!!");
        }
        else
        {
            Debug.Log("BENERIN LAGI MASIH SALAH BRE");
        }
    }
}
