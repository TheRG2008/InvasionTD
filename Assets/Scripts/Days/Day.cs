using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Day/New Day", fileName = "New Day")]
public class Day : ScriptableObject
{
    [SerializeField] private int _dayNumber; 
    [SerializeField] public AtackZone[] _atackZone;
    public bool IsActive = false;
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

    public void EndDayCheck()
    {
        int counter = 0;
        for (int i = 0; i < _atackZone.Length; i++)
        {
            _atackZone[i].IsDayEnd();
        }
        for (int i = 0; i < _atackZone.Length; i++)
        {
            counter += _atackZone[i].CounterZone;
        }

        if (counter == 0)
        {
            Debug.Log("День закончен");
        }
    }
}
