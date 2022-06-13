using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter1Setting : MonoBehaviour
{
    public void enable(){
        gameObject.SetActive(true);
    }

    public void back(){
        gameObject.SetActive(false);
    }
}
