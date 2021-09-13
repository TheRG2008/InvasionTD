using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;    
    private NavMeshAgent _navMeshAgent;
    int _CurrentWaypointIndex;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        _navMeshAgent.SetDestination(_waypoints[0].position);
    }
    void Update()
    {
        
        if (_navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
        {
            _CurrentWaypointIndex = (_CurrentWaypointIndex + 1) % _waypoints.Length;
            _navMeshAgent.SetDestination(_waypoints[_CurrentWaypointIndex].position);
        }
    }

}
