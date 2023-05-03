using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewUnitData", menuName = "CardData/Unit")]
public class UnitData : CardData
{
    [Header("Combat Stats")]
    [SerializeField] private int _atk;
    [SerializeField] private int _def;

    public int Atk => _atk;
    public int Def => _def;
}
