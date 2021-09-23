using UnityEngine;
public class Player : MonoBehaviour
{
    private int _gold = 0;
    private int _exp = 0;
    private int _gameDay = 0;
    

    public int Gold 
    { 
        get => _gold;
        set
        {
            if ((_gold - value) < 0)
            {
                Debug.Log("Нехватает денег на покупку");
                return;
            } 
            _gold = value;            
        }
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
