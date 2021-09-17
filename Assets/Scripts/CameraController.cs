using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Timers;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _startPointCamera;    
    [SerializeField] private GameObject [] _zones;
    
    private Player _player;

    private void Awake()
    {      
        CameraStartPosition();
        _player = new Player();        
    }

    public void CameraMoveForZone (Transform zonePoint)
    {
        HideZonePanel();
        _camera.transform.position = zonePoint.transform.position;
    }
    public void CameraStartPosition()
    {
        ShowZonePanel();
        _camera.transform.position = _startPointCamera.transform.position;
    }
    public void HideZonePanel ()
    {
        for (int i = 0; i < _zones.Length; i++)
        {
            _zones[i].gameObject.SetActive(false);
        }
    }
    public void ShowZonePanel()
    {
        for (int i = 0; i < _zones.Length; i++)
        {
            _zones[i].gameObject.SetActive(true);
        }
    }

   
   
}
