using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Day/Wave", fileName = "Wave")]
public class Wave : ScriptableObject
{
    [SerializeField] private int _countWave;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private int _enemyCount;

    public int CountWave
        => _countWave;
    public int EnrmyCount
        => _enemyCount;
}
