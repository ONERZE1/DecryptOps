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
    private void Awake() {
        answerNumber = angkaUtama.GetComponent<OnDropAngkaUtama>().angkaUtama;
        goalNumber = angkaUtama.GetComponent<OnDropAngkaUtama>().angkaTujuan;
    }
    void Start()
    {
       angkaTujuan.text = "" + angkaUtama.GetComponent<OnDropAngkaUtama>().angkaTujuan; 
    }

    public void isAnswerCorrect(){
        if(angkaUtama == angkaTujuan){

            Debug.Log("DAH BENER!!!");
        }
        else
        {
            Debug.Log("BENERIN LAGI MASIH SALAH BRE");
        }
    }
}
