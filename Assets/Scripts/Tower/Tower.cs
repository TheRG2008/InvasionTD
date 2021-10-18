using System.Collections;
using UnityEngine;

public class Tower : MonoBehaviour, ITower
{
    [SerializeField] private int    _damage;
    [SerializeField] private float  _projectileSpeed;
    [SerializeField] private float  _shootDelay;
    [SerializeField] private int    _radiusAtack;
    [SerializeField] private int    _goldForUpgrade;
    [SerializeField] private bool   _isOpen;
    [SerializeField] private int    _goldForBiilding;
    [SerializeField] private TypeTower _typeTower;
    [SerializeField] private GameObject _projectile;
    [SerializeField] private GameObject _target;
    private Player _player;
    private bool _lockedOnEnemy;
    private bool _isShooting;

    public int      Damage { get => _damage; set => _damage = value; }
    public float    ProjectileSpeed { get => _projectileSpeed; set => _projectileSpeed = value; }
    public int      RadiusAtack { get => _radiusAtack; set => _radiusAtack = value; }
    public int      GoldForUpgrade { get => _goldForUpgrade; set => _goldForUpgrade = value; }
    public bool     IsOpen { get => _isOpen; set => _isOpen = value; }
    public TypeTower TypeTower { get => _typeTower; set => _typeTower = value; }
    public int      GoldForBuilding { get => _goldForBiilding; set => _goldForBiilding = value; }
    public float    ShootDelay { get => _shootDelay; set => _shootDelay = value; }

    public GameObject Target { get => _target; set { _lockedOnEnemy = value == null ? false : true; _target = value; } }
 

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy") && !_lockedOnEnemy && Target == null)
        {
            Target = other.gameObject;
        }
        if (other.GetComponent<IEnemy>().HP <= 0)
        {
            Target = null;
        }        
        if (!_isShooting)
        {
            StartCoroutine(Shoot());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && !_lockedOnEnemy && Target == null)
        {
            Target = other.gameObject;
        }
        
        if (!_isShooting)
        {
            StartCoroutine(Shoot());
        }   
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Target)
        {
            Target = null;
        }
    }

    public void Build()
    {
        _player.Gold -= _goldForBiilding;
    }

    IEnumerator Shoot()
    {
        _isShooting = true;
        yield return new WaitForSeconds(ShootDelay);

        if (Target== true)
        {
            GameObject projectile = Instantiate(_projectile, transform.position, Quaternion.identity);
            projectile.GetComponent<Projectile>().Target = Target;
            projectile.GetComponent<Projectile>().Speed = ProjectileSpeed;
            projectile.GetComponent<Projectile>().Tower = this;
        }
        _isShooting = false;
    }
}
