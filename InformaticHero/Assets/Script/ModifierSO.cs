using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Modifier", fileName = "New Modifier")]
public class ModifierSO : ScriptableObject
{
    [SerializeField]public int number = 0;
    [SerializeField]public string operators = "isi dengan X,+,-,/";
    

    public int getModiferNumber()
    {
        return number;
    }
    public string getModifierOperators()
    {
        return operators;
    }
}
