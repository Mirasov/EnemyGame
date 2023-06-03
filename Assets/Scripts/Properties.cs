using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Properties : MonoBehaviour
{
  
    public List<int> ListA;

    public Dictionary<string, Color> ColorMap;
    public Dictionary<int, GameObject> Inventory;

    [SerializeField] private TMP_InputField _input;
    [SerializeField] private MeshRenderer _cubeRenderer;

    private void Awake()
    {
        ColorMap = new Dictionary<string, Color>();
        ColorMap.Add("red", Color.red);
        ColorMap.Add("green", Color.green);
        ColorMap.Add("blue", Color.blue);

        ColorMap.Add("brown", new Color(1.0f, 0.5f, 0.5f, 1f));
    }

    private void Update()
    {
        if (ColorMap.ContainsKey(_input.text))
        {
            _cubeRenderer.material.color = ColorMap[_input.text];
        }
    }
}
