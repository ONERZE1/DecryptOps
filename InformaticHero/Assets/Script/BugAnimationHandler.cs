using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugAnimationHandler : MonoBehaviour
{
    public CanvasGroup Bugs;

    void Start() {
        animate();
    }
    void animate(){
        Bugs.alpha = 0.3f;
        Bugs.LeanAlpha(1, 1.5f).setLoopPingPong();
    }
}
