using UnityEngine;

public class Gates : MonoBehaviour, IBuilding
{
    [SerializeField] private GameObject[] _gates;
    [SerializeField] private int[] _goldForFixUp;
    [SerializeField] private GameObject _fortification;
    [SerializeField] private int _life = 50;
    private int _goldForBuilding;
    private int _lvl = 5;
    private Player _player;
    

    public int Life
    {
        get => _life;
        set
        {
            _life = value;
            FixDown(_life);
            if (_life <= 0)
            {
                //Instantiate(_fortification, gameObject.transform);
                Die();
            }  
        }
    }
    public int Lvl
    {
        get => _lvl;
        set => _lvl = value;
    }
    public int [] GoldForFixUp
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

    public void FixUp()
    {
        switch (_lvl)
        {
            case 1:
                FixUpCheck(_lvl - 1, 4);                
                break;
            case 2:
                FixUpCheck(_lvl - 1, 3);
                break;
            case 3:
                FixUpCheck(_lvl - 1, 2);
                break;
            case 4:
                FixUpCheck(_lvl - 1, 1);
                break;
        }
    }

    private void FixUpCheck(int index, int gate)
    {
        if (_player.Gold >= _goldForFixUp[index])
        {
            _player.Gold -= _goldForFixUp[index];
            _gates[gate].SetActive(false);
            _gates[gate - 1].SetActive(true);
            _lvl++;
        }
        else
            Debug.Log("Не хватает денег на улучшение");
    }

    public void FixDown(int life)
    {
        if(life <= 40 && life > 30)
        {
            _gates[0].SetActive(false);
            _gates[1].SetActive(true);
            _lvl = 4;
        }
        else if (life <= 30 && life > 20)
        {
            _gates[1].SetActive(false);
            _gates[2].SetActive(true);
            _lvl = 3;
        }
        else if (life <= 20 && life > 10)
        {
            _gates[2].SetActive(false);
            _gates[3].SetActive(true);
            _lvl = 2;
        }
        else if (life <= 10 && life > 0)
        {
            _gates[3].SetActive(false);
            _gates[4].SetActive(true);
            _lvl = 1;
        }
        else
        {
            return;
        }        
    }
  

    public void Build()
    {
        
    }

    public void Die()
    {
        _lvl = 0;       
        Debug.Log("Ворота разрушены");
        Destroy(gameObject);
    }


    public void GetDamage(IEnemy enemy)
    {
        Life -= enemy.BuildingDamage;
    }
}
