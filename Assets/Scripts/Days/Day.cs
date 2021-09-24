using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Day/New Day", fileName = "New Day")]
public class Day : ScriptableObject
{
    [SerializeField] private int _dayNumber; 
    [SerializeField] public AtackZone[] _atackZone;
    public int Size { get; }
    public int DayNumber
        => _dayNumber;

    public Day(int size)
    {
        Size = size;
        _atackZone = new AtackZone[size];

    }
    public AtackZone GetAtackZone(int index)
    {
        return _atackZone[index];
    }

}
