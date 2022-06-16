using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    public static MusicControl instance;

    private void awake(){
        DontDestroyOnLoad(this.gameObject);
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
