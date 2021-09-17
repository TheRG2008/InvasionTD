using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Day/AtackZone", fileName = "Atack Zone")]
public class AtackZone : ScriptableObject
{
    [SerializeField] private Wave[] _wavesAtack;
    [SerializeField] private float _timeToStartWave;
    [SerializeField] private float _timeToStartNextWave;
    [SerializeField] private GameObject Zone;

    public float TimeToStartWave
        => _timeToStartWave;
    public float TimeToStartNextWave
        => _timeToStartNextWave;

    public Wave GetWave(int index)
    {
        return _wavesAtack[index];
    }
}
