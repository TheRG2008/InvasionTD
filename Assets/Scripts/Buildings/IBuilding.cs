using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface  IBuilding 
{
   
    public int Life { get; set; }
    public int Lvl { get; set; }
    public int[] GoldForFixUp { get; }
    public int GoldForBuilding { get; }

    public void GetDamage(IEnemy enemy);

    public void Die();

    public void Build();

    public void FixUp();
    

}
