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

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Enemy>())
        {
            IEnemy enemy = other.GetComponent<Enemy>();
            GetDamage(enemy);
            Destroy(other.gameObject);
        }
    }
    public void Build()
    {
        
    }

    public void Die()
    {
        Debug.Log("Ратуша разрушена");
        Destroy(gameObject);
    }

    public void FixUp()
    {
        
    }

    public void GetDamage(IEnemy enemy)
    {
        Life -= enemy.BuildingDamage;
    }
}
