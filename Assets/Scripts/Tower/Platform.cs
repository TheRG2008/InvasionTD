using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private GameObject SelectedMenu;
   public void ItsWork ()
    {
        Debug.Log("��������!");
    }

    public void ShowSelectPanel()
    {
        SelectedMenu.SetActive(true);
    }
    public void HideSelectPanel()
    {
        SelectedMenu.SetActive(false);
    }



}
