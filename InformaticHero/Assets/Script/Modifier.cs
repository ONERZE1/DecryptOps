using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Modifier : MonoBehaviour
{
    public GameObject gameObj;
    public GameObject angka;
    int inisialAngkaUtama;
    public TextMeshProUGUI angkaDisplay;
    private void Awake()
    {
        angka.GetComponent<OnDropAngkaUtama>().Awake();
        inisialAngkaUtama = angka.GetComponent<OnDropAngkaUtama>().angkaUtama;
    }

    public void resetMod()
    {
        for (int i = 0; i < gameObj.transform.childCount; i++)
        {
           gameObj.transform.GetChild(i).gameObject.SetActive(true);
        }
        angka.GetComponent<OnDropAngkaUtama>().angkaUtama = inisialAngkaUtama;
    }
}
