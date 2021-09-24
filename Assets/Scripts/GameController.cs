using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    [SerializeField] private Days _days;
    private Player _player;
    private Day _day;
    private List<AtackZone> _currentAtackZones;

    private void Awake()
    {        
        _currentAtackZones = new List<AtackZone>(); 
        _player = new Player();
    }

    public void StartDay()
    {

        _day = _days.GetCurrentDay(_player.GameDay);
        TimerToStartWaves();
        GetCurentAtackZone();
        StartWave();
        //_player.GameDay++;
    }

    private void GetCurentAtackZone()
    {
        for (int i = 0; i < _day._atackZone.Length; i++)
        {
            _currentAtackZones.Add(_day.GetAtackZone(i));
        }
        
    }
    private void StartWave ()
    {
        for (int i = 0; i < _currentAtackZones.Count; i++)
            for (int j = 0; j < _currentAtackZones[i]._wavesAtack.Length; j++)
            {
                Wave wave = _currentAtackZones[i]._wavesAtack[j];                
                if (wave.NumberWave == 1)
                {
                    wave.StartWave();
                }
            }
        
    }



    private void TimerToStartWaves ()
    {

    }
}
