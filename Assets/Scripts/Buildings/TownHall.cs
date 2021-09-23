using UnityEngine;

public class TownHall : MonoBehaviour, IBuilding
{
    [SerializeField] private int _life;
    private int _goldForBuilding;
    private int _lvl;
    private int[] _goldForFixUp;
    public int Life 
    { 
        get => _life;
        set
        {
            _life = value;
            if (_life <= 0)
                Die();
        }
             
    }
    public int Lvl 
    { 
        get => _lvl; 
        set => _lvl = value; 
    }
    public int[] GoldForFixUp 
    { 
        get => _goldForFixUp; 
        
    }
    public int GoldForBuilding 
        => _goldForBuilding;

    public void Build()
    {
        
    }

    public void Die()
    {
        Debug.Log("������ ���������");
    }

    public void FixUp()
    {
        
    }

    public void GetDamage(IEnemy enemy)
    {
        _life -= enemy.BuildingDamage;
    }
}
