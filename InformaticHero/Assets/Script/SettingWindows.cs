using System.Collections.Specialized;
using System.Transactions;
using System.Runtime.Intrinsics;
using System.Numerics;
using System.Threading.Tasks.Dataflow;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingWindows : MonoBehaviour
{
    private void start(){
        transform.localScale = Vector2.zero;
    }
    public void open(){
        transform.LeanScale(Vector2.one, 0.8f);
    }
    public void close(){
        transform.LeanScale(Vector2.zero, 1f).setEaseInBack(); 
    }
}
