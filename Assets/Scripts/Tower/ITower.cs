using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITower
{
    public int Damage { get; set; }
    public float DamageSpeed { get; set; }
    public int RadiusAtack { get; set; }
    public int GoldForUpgrade { get; set; }
    public bool IsOpen { get; set; }

    public void Atack(IEnemy enemy);
    public void Upgrade();
    public void Build();
}
