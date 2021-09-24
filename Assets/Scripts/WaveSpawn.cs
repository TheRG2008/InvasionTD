using UnityEngine;
using System.Collections;
public class WaveSpawn : MonoBehaviour {

	public int waveSize;
	public GameObject EnemyPrefab;
	public float EnemyInterval;
	public Transform spawnPoint;
	public float startTime;
	public Transform[] WayPoints;

	public int EnemyCount
	{
		get { return enemyCount; }
		set
		{
			enemyCount = value;
			if (enemyCount == waveSize)
			{
				CancelInvoke("SpawnEnemy");
			}
		}
	}
	private int enemyCount;

	void Start ()
    {
	 InvokeRepeating("SpawnEnemy",startTime,EnemyInterval);
	}


	void SpawnEnemy()
	{
		EnemyCount++;
		GameObject enemy = GameObject.Instantiate(EnemyPrefab,spawnPoint.position,Quaternion.identity) as GameObject;
		enemy.GetComponent<Enemy>().waypoints = WayPoints;
      
    }
}
