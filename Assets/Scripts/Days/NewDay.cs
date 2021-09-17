using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Day/New Day", fileName = "New Day")]
public class NewDay : ScriptableObject
{
    [Tooltip("Порядковый номер дня")]
    [SerializeField] private int _dayNumber;
    public int DayNumber    
        => _dayNumber;

    [Tooltip("Зоны атаки в текущий день")]
    [SerializeField] private AtackZone[] _atackZone;

    public AtackZone GetAtackZone(int index)
    {
        return _atackZone[index];
    }

}
