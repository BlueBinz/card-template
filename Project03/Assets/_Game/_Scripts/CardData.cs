using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardData : ScriptableObject
{
    [Header("General Info")]
    [SerializeField] private string _name;
    [SerializeField] private CardType _type = CardType.None;
    [Tooltip("Text at the bottom of the card that adds context or lore.")]
    [SerializeField] private string _flavor;

    [Header("Effect")]
    [Tooltip("Card text that describes its effect(s).")]
    [SerializeField] private string _text;
    [Tooltip("How many targets the card has (-1 for your board, -2 for enemy board, -3 for all boards)")]
    [SerializeField] private int _target;
    [Tooltip("When the effect occurs.")]
    [SerializeField] private EffectType _effectType;

    [Header("Stats")]
    [SerializeField] [Range(1, 9)] private int _cost;


    //getters
    public string Name => _name;
    public CardType Type => _type;
    public string Text => _text;
    public string Flavor => _flavor;
    public int Cost => _cost;

}
