using UnityEngine;

public class Days : MonoBehaviour
{
    [SerializeField] public Day[] _days;

    private void Awake()
    {
        Debug.Log(_days[0].name);
    }
    public Day GetCurrentDay (int index)
    {
        if (_days != null)
        {
            return _days[index];
        }
        Debug.Log("Дня с таким номером не создано");
        return null;
    }
}
