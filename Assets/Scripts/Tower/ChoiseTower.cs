using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiseTower : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private GameObject[] _platforms;
    void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChoisObject();
        }
    }
    public void ChoisObject()
    {
        RaycastHit hit;
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {          
            if (hit.collider.gameObject.GetComponent<Platform>())
            {
                HideChoiseTowerMenu();
                hit.collider.gameObject.GetComponent<Platform>().ShowSelectPanel();

            }
            else if (hit.collider.gameObject.GetComponent<TypeTowerInSelectMenu>())
            {
                TypeTowerInSelectMenu selectMenu = hit.collider.gameObject.GetComponent<TypeTowerInSelectMenu>();
                TypeTower type = selectMenu._typeTower;
                selectMenu.BuildTower(type);
            }
            else if (hit.collider.gameObject.GetComponent<Tower>())
            {
                Tower tower = hit.collider.gameObject.GetComponent<Tower>();
                Debug.Log($"Выбрана башня типа {tower.TypeTower}");
            }
            else
            {
                HideChoiseTowerMenu();
            }  

            return; 
        }
    }

    public void HideChoiseTowerMenu()
    {
        for (int i = 0; i < _platforms.Length; i++)
        {
            if (_platforms[i].transform.GetChild(1) != null)
            {
                _platforms[i].transform.GetChild(1).gameObject.SetActive(false);
            }
        }
    }
}
