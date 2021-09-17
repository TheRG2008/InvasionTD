using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class Fortifications : MonoBehaviour, IBuilding

{
    [SerializeField] private GameObject[] _gates;
    [SerializeField] private int _life;
    [SerializeField] private int[] _goldForFixUp;    
    private int _goldForBuilding;
    private int _lvl;
    private Player _player;

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

    public void FixUp()
    {
        switch (_lvl)
        {
            case 1:
                FixUpCheck(_lvl - 1);
                break;
            case 2:
                FixUpCheck(_lvl - 1);
                break;
            case 3:
                FixUpCheck(_lvl - 1);
                break;
            case 4:
                FixUpCheck(_lvl - 1);
                break;
        }
    }
    private void FixUpCheck(int index)
    {
        if (_player.Gold >= _goldForFixUp[index])
        {
            _player.Gold -= _goldForFixUp[index];
            _gates[index - 1].SetActive(false);
            _gates[index].SetActive(true);
            _lvl++;
        }
        else
            Debug.Log("Не хватает денег на улучшение");
    }

    public void Build()
    {
        if (_player.Gold >= _goldForBuilding)
        {
            _player.Gold -= _goldForBuilding;            
            _gates[0].SetActive(true);
            _lvl++;
        }
        else
            Debug.Log("Не хватает денег на улучшение");
    }

    public void Die()
    {
        _lvl = 0;
        for (int i = 0; i < _gates.Length; i++)
        {
            _gates[i].SetActive(false);
        }
        Debug.Log("Ратуша разрушена");
        
    }


    public void GetDamage(IEnemy enemy)
    {
        _life -= enemy.BuildingDamage;
    }

}

