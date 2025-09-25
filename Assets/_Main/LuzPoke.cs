using UnityEngine;

public class LuzPoke : MonoBehaviour
{
    private bool _flag = false;
    [SerializeField] private GameObject luzPoke;
    public void SwitchLuz() {
        luzPoke.SetActive(!_flag);
        _flag = !_flag;
    }

}
