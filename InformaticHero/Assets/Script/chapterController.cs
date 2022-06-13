using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chapterController : MonoBehaviour
{
        public void enable(){
        gameObject.SetActive(true);
    }

    public void back(){
        gameObject.SetActive(false);
    }
}

