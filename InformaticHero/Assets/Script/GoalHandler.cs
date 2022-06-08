using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoalHandler : MonoBehaviour
{
    public GameObject angkaUtama;
    public TextMeshProUGUI angkaTujuan;
    int goalNumber,answerNumber;
    
    void Start()
    {
       angkaTujuan.text = "" + angkaUtama.GetComponent<OnDropAngkaUtama>().angkaTujuan; 
    }

    public void isAnswerCorrect(){

        answerNumber = angkaUtama.GetComponent<OnDropAngkaUtama>().angkaUtama;
        goalNumber = angkaUtama.GetComponent<OnDropAngkaUtama>().angkaTujuan;

      
        if(answerNumber== goalNumber){

            Debug.Log("DAH BENER!!!");
        }
        else
        {
            Debug.Log("BENERIN LAGI MASIH SALAH BRE");
        }
    }
}
