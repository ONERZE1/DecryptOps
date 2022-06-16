using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Modifier : MonoBehaviour
{
    public GameObject gameObj;
    public GameObject angka, angka2;
    int inisialAngkaUtama, inisialAngkaUtama2;
    public TextMeshProUGUI angkaDisplay;
    private void Awake()
    {
        angka.GetComponent<OnDropAngkaUtama>().Awake();
        inisialAngkaUtama = angka.GetComponent<OnDropAngkaUtama>().angkaUtama;
        if(angka2 != null)
        {
            angka2.GetComponent<OnDropAngkaUtama>().Awake();
            inisialAngkaUtama2 = angka2.GetComponent<OnDropAngkaUtama>().angkaUtama;
        }
        
    }

    public void resetMod()
    {
        for (int i = 0; i < gameObj.transform.childCount; i++)
        {
           gameObj.transform.GetChild(i).gameObject.SetActive(true);
        }
        angka.GetComponent<OnDropAngkaUtama>().angkaUtama = inisialAngkaUtama;
        if(angka2 != null)
        {
            angka2.GetComponent<OnDropAngkaUtama>().angkaUtama = inisialAngkaUtama2;
        }
        Debug.Log(inisialAngkaUtama);
    }
}
