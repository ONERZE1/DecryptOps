using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Numbers", fileName = "New Numbers")]
public class NumbersSo : ScriptableObject
{
    [SerializeField] int angkaUtama = 10;
    [SerializeField] int angkaTujuan;

    public int getGoalNumber()
    {
        return angkaTujuan;
    }
    public int getMainNumber()
    {
        return angkaUtama;
    }
}
