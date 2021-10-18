using UnityEngine;

public class Enemy : MonoBehaviour, IEnemy
{
    [SerializeField] private int _hp;
    [SerializeField] private float _speed;
    [SerializeField] private int _defence;
    [SerializeField] private int _buildingDamage;
    [SerializeField] private int _goldForDeath;
    [SerializeField] private int _expForDeath;
    [SerializeField] private TypeEnemy _typeEnemy;
    [SerializeField] private TypeAtack typeDefence;
    private int _curWaypointIndex = 0;
    public Transform[] waypoints;
    public float Speed { get => _speed; set => _speed = value; }
    public int Defence { get => _defence; set => _defence = value; }
    public int BuildingDamage { get => _buildingDamage; set => _buildingDamage = value; }
    public int GoldForDeath { get => _goldForDeath; set => _goldForDeath = value; }
    public int ExpForDeath { get => _expForDeath; set => _expForDeath = value; }
    public int HP
    {
        get => _hp;
        set
        {
            _hp = value;
            if (_hp <= 0)
                Die();
        }
    }

    void Update()
    {
        if (_curWaypointIndex < waypoints.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[_curWaypointIndex].position, Time.deltaTime * Speed);

            transform.LookAt(waypoints[_curWaypointIndex].position);

            if (Vector3.Distance(transform.position, waypoints[_curWaypointIndex].position) < 0.5f)
            {
                _curWaypointIndex++;
            }
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }

    public void GetDamge(int damage)
    {
        HP -= damage;
    }

    public void Walk()
    {
    }
}
