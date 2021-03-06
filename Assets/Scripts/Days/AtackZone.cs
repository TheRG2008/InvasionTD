using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Day/AtackZone", fileName = "Atack Zone")]
public class AtackZone : ScriptableObject
{
    [SerializeField] public Wave[] _wavesAtack;
    [SerializeField] private float _timeToStartWave;
    [SerializeField] private float _timeToStartNextWave;
    [SerializeField] private GameObject _zone;
    public int Size { get; }
    public float TimeToStartWave
        => _timeToStartWave;
    public float TimeToStartNextWave
        => _timeToStartNextWave;
    public GameObject Zone
        => _zone;
        
    public AtackZone (int size)
    {
        Size = size;
        _wavesAtack = new Wave[size];

    }

    public Wave GetWave(int index)
    {
        return _wavesAtack[index];
    }
}
