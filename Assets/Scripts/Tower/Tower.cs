using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour, ITower
{
    private int _damage;
    private float _damageSpeed;
    private int _radiusAtack;
    private int _goldForUpgrade;
    private bool _isOpen;

    public int Damage { get => _damage; set => _damage = value; }
    public float DamageSpeed { get => _damageSpeed; set => _damageSpeed = value; }
    public int RadiusAtack { get => _radiusAtack; set => _radiusAtack = value; }
    public int GoldForUpgrade { get => _goldForUpgrade; set => _goldForUpgrade = value; }
    public bool IsOpen { get => _isOpen; set => _isOpen = value; }

    public void Atack(IEnemy enemy)
    {
        enemy.GetDamge(_damage);
    }

    public void Build()
    {

    }

    public void Upgrade()
    {

    }
}
