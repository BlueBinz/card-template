using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Card : MonoBehaviour
{
    [Header("Card Data")]
    [SerializeField] private CardData _data;

    //holds all of the text attributes
    [Header("Text Attributes")]
    [SerializeField] private TextMeshProUGUI _cardTypeText;
    [SerializeField] private TextMeshProUGUI _cardTextText;
    [SerializeField] private TextMeshProUGUI _cardCostText;
    [SerializeField] private TextMeshProUGUI _cardAtkText;
    [SerializeField] private TextMeshProUGUI _cardDefText;
    [SerializeField] private TextMeshProUGUI _cardFlavorText;
    [SerializeField] private TextMeshProUGUI _cardNameText;

    //temporary stat counters for buffs / debuffs
    private int tempAtk = 0;
    private int tempDef = 0;

    private int damage = 0;

    //sets text attributes to script attributes
    private void Start()
    {
        _cardTypeText.text = _data.Type.ToString();
        _cardTextText.text = _data.Text;
        _cardCostText.text = _data.Cost.ToString();
        _cardAtkText.text = _data.Atk.ToString();
        _cardDefText.text = _data.Def.ToString();
        _cardFlavorText.text = _data.Flavor;
        _cardNameText.text = _data.Name;
    }
}
