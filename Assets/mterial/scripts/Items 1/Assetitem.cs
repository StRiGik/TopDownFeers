using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Item")]
public class Assetitem : ScriptableObject, IItems
{
    public string Name => _name;
    public Sprite UIIcon => _uiIcon;
    public int ID => _id;

    [SerializeField] private string _name;
    [SerializeField] private Sprite _uiIcon;
    [SerializeField] private int _id;

}

