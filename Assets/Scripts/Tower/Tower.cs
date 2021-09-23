using UnityEngine;

public class Tower : MonoBehaviour, ITower
{
    [SerializeField] private int _damage;
    [SerializeField] private float _damageSpeed;
    [SerializeField] private int _radiusAtack;
    [SerializeField] private int _goldForUpgrade;
    [SerializeField] private bool _isOpen;
    [SerializeField] private int _goldForBiilding;
    [SerializeField] private TypeTower _typeTower;
    private Player _player;

    public int Damage { get => _damage; set => _damage = value; }
    public float DamageSpeed { get => _damageSpeed; set => _damageSpeed = value; }
    public int RadiusAtack { get => _radiusAtack; set => _radiusAtack = value; }
    public int GoldForUpgrade { get => _goldForUpgrade; set => _goldForUpgrade = value; }
    public bool IsOpen { get => _isOpen; set => _isOpen = value; }
    public TypeTower TypeTower { get => _typeTower; set => _typeTower = value; }
    public int GoldForBuilding { get => _goldForBiilding; set => _goldForBiilding = value; }

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
}
