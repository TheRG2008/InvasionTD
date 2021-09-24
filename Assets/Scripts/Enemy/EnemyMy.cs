using UnityEngine;

public class EnemyMy : MonoBehaviour, IEnemy
{
    private int _hp;
    private float _speed;
    private int _defence;
    private int _buildingDamage;
    private int _goldForDeath;
    private int _expForDeath;
    private TypeEnemy _typeEnemy;
    private TypeAtack typeDefence;
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
