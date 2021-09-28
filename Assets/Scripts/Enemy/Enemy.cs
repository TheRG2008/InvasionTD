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
    public Transform[] waypoints;
    private int curWaypointIndex = 0;
    public Wave wave;
    private Days day;
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
    public float Speed { get => _speed; set => _speed = value; }
    public int Defence { get => _defence; set => _defence = value; }
    public int BuildingDamage { get => _buildingDamage; set => _buildingDamage = value; }
    public int GoldForDeath { get => _goldForDeath; set => _goldForDeath = value; }
    public int ExpForDeath { get => _expForDeath; set => _expForDeath = value; }

    void Update()
    {
        if (curWaypointIndex < waypoints.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[curWaypointIndex].position, Time.deltaTime * Speed);

            transform.LookAt(waypoints[curWaypointIndex].position);

            if (Vector3.Distance(transform.position, waypoints[curWaypointIndex].position) < 0.5f)
            {
                curWaypointIndex++;
            }
        }
    }
    public void Die()
    {
        wave.CheckALifeEnemy();
        for (int i = 0; i < day._days.Length; i++)
        {
            if(day._days[i].IsActive)
            {
                day._days[i].EndDayCheck();
            }
        }
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
