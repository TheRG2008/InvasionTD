using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _gold;
    [SerializeField] private int _exp;
    [SerializeField] private int _gameDay = 1;
    

    public int Gold 
    { 
        get => _gold; 
        set => _gold = value; 
    }
    public int Exp 
    { 
        get => _exp; 
        set => _exp = value; 
    }
    public int GameDay 
    { 
        get => _gameDay; 
        set => _gameDay = value; 
    }


   
}
