using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCardData", menuName = "CardData/Card")]
public class CardData : ScriptableObject
{
    [Header("General Info")]
    [SerializeField] private string _name;
    [SerializeField] private CardType _type = CardType.None;
    [Tooltip("Card text that describes its effect(s).")]
    [SerializeField] private string _text;
    [Tooltip("Text at the bottom of the card that adds context or lore.")]
    [SerializeField] private string _flavor;

    [Header("Stats")]
    [SerializeField] [Range(1, 9)] private int _cost;
    [SerializeField] private int _atk;
    [SerializeField] private int _def;

    //getters
    public string Name => _name;
    public CardType Type => _type;
    public string Text => _text;
    public string Flavor => _flavor;
    public int Cost => _cost;
    public int Atk => _atk;
    public int Def => _def;
}
