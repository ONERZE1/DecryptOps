using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modifier : MonoBehaviour
{
    public GameObject gameObj;
    public GameObject angka;
    int inisialAngkaUtama;
    private void Awake()
    {
        angka.GetComponent<OnDropAngkaUtama>().Awake();
        inisialAngkaUtama = angka.GetComponent<OnDropAngkaUtama>().angkaUtama;
    }

    public void resetMod()
    {
        gameObj.transform.GetChild(0).gameObject.SetActive(true);
        gameObj.transform.GetChild(1).gameObject.SetActive(true);
        gameObj.transform.GetChild(2).gameObject.SetActive(true);
        gameObj.transform.GetChild(3).gameObject.SetActive(true);
        gameObj.transform.GetChild(4).gameObject.SetActive(true);
        Debug.Log(inisialAngkaUtama);
        angka.GetComponent<OnDropAngkaUtama>().angkaUtama = inisialAngkaUtama;
    }
}
