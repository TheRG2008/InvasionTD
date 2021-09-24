using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Wave : MonoBehaviour
{
	[SerializeField] private int _waveSize;
	[SerializeField] private int _enemyCount;
	[SerializeField] private float _enemyInterval;
	[SerializeField] private float _startTime;
	[SerializeField] private GameObject _enemyPrefab;
	[SerializeField] private Transform _spawnPoint;
	[SerializeField] private Transform[] _wayPoints;
	[SerializeField] private int _numberWave;

	public int EnemyCount
	{
		get => _enemyCount; 
		set
		{
			_enemyCount = value;
			if (_enemyCount == _waveSize)
			{
				CancelInvoke("SpawnEnemy");
				_enemyCount = 0;
			}
		}
	}
    public int NumberWave
        => _numberWave;

	public void StartWave()
	{
		InvokeRepeating("SpawnEnemy", _startTime, _enemyInterval);
	}


	void SpawnEnemy()
	{
		EnemyCount++;
		GameObject enemy = Instantiate(_enemyPrefab, _spawnPoint.position, Quaternion.identity) as GameObject;
		enemy.GetComponent<Enemy>().waypoints = _wayPoints;

	}
}
