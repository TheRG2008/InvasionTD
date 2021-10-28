using UnityEngine;

public class Tower : MonoBehaviour, ITower
{
    [SerializeField] private int _damage;
    [SerializeField] private float _damageSpeed;
    [SerializeField] private float _radiusAtack;
    [SerializeField] private int _goldForUpgrade;
    [SerializeField] private bool _isOpen;
    [SerializeField] private int _goldForBiilding;
    [SerializeField] private TypeTower _typeTower;
    private Player _player;

    public int Damage { get => _damage; set => _damage = value; }
    public float DamageSpeed { get => _damageSpeed; set => _damageSpeed = value; }
    public float RadiusAtack { get => _radiusAtack; set => _radiusAtack = value; }
    public int GoldForUpgrade { get => _goldForUpgrade; set => _goldForUpgrade = value; }
    public bool IsOpen { get => _isOpen; set => _isOpen = value; }
    public TypeTower TypeTower { get => _typeTower; set => _typeTower = value; }
    public int GoldForBuilding { get => _goldForBiilding; set => _goldForBiilding = value; }

    private void Update()
    {

        EnemyDetected();
    }
    public void Atack(IEnemy enemy)
    {
        enemy.GetDamge(_damage);
    }

    public void Build()
    {
        _player.Gold -= _goldForBiilding;
    }

    public void Upgrade()
    {

    }

    public void EnemyDetected()
    {
        Collider[] enemyColliders = Physics.OverlapSphere(transform.position, _radiusAtack);
        for (int i = 0; i < enemyColliders.Length ; i++)
        {
            Rigidbody rigidbody = enemyColliders[i].attachedRigidbody;
            if (rigidbody)
            {
                Enemy enemy = rigidbody.GetComponent<Enemy>();
                if (enemy)
                {
                    Debug.Log($"Атакуем врага, урон = {_damage}");
                    Atack(enemy);

                }
            }
            
        }
    }
}
