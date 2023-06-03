using TMPro;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    public float Health
    {
        get
        {
            return _health;
        }
        set
        {
            _text.text = $"{value} / 100";
            _health = value;
        }
    }

    private float _health = 100;
}
