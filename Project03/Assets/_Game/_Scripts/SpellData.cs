using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewSpellData", menuName = "CardData/Spell")]
public class SpellData : CardData
{
    [Header("Spell Stats")]
    [SerializeField] private int _spellDamage;
}
