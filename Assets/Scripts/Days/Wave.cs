using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Day/Wave", fileName = "Wave")]
public class Wave : ScriptableObject
{
    [SerializeField] private int _numberWave;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private int _enemyCount;
   

    public int NumberWave
        => _numberWave;
    public int EnemyCount
        => _enemyCount;

    public void StartWave (GameObject enemySpawn)
    {
       
        for (int i = 0; i < _enemyCount; i++)
        {
            Debug.Log($"Враг {i+1} создан");
            Instantiate(_enemy, enemySpawn.transform);            
        }
    }
}
