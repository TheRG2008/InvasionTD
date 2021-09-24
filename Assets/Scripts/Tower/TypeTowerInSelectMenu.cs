using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeTowerInSelectMenu : MonoBehaviour
{
    [SerializeField] public TypeTower _typeTower;
    [SerializeField] private GameObject[] _towers;
    [SerializeField] private Transform _pointBuldingTower;
    [SerializeField] private GameObject _platform;

    public void BuildTower (TypeTower typeTower)
    {
        for (int i = 0; i < _towers.Length; i++)
        {
            TypeTower type = _towers[i].GetComponent<Tower>().TypeTower;
            if (type == typeTower)
            {
                Instantiate(_towers[i], _pointBuldingTower);
                Debug.Log("Построили башню");
                _platform.GetComponent<Platform>().HideSelectPanel();
            }
        }
    }
    
}
