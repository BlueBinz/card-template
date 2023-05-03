using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Card : MonoBehaviour
{
    [Header("Card Base Materials")]
    [SerializeField] private Material _unitMaterial;
    [SerializeField] private Material _spellMaterial;

    [Header("Card Data")]
    [SerializeField] public CardData _data;

    //holds all of the text attributes
    [Header("Text Attributes")]
    [SerializeField] private TextMeshProUGUI _cardTypeText;
    [SerializeField] private TextMeshProUGUI _cardTextText;
    [SerializeField] private TextMeshProUGUI _cardCostText;
    [SerializeField] private TextMeshProUGUI _cardAtkText;
    [SerializeField] private TextMeshProUGUI _cardDefText;
    [SerializeField] private TextMeshProUGUI _cardFlavorText;
    [SerializeField] private TextMeshProUGUI _cardNameText;

    //temporary stat counters for buffs / debuffs - for use if unit card
    private int tempAtk = 0;
    private int tempDef = 0;

    //stat counter for either how much damage unit has taken OR how much damage spell does
    private int damage = 0;

    //sets text attributes to script attributes
    private void Start()
    {
        _cardTypeText.text = _data.Type.ToString();
        _cardTextText.text = _data.Text;
        _cardCostText.text = _data.Cost.ToString();
        _cardFlavorText.text = _data.Flavor;
        _cardNameText.text = _data.Name;

        //if unit card, need to reflect combat stats as well as change card material
        UnitData ud = _data as UnitData;
        if(ud != null)
        {
            _cardAtkText.enabled = true;
            _cardDefText.enabled = true;
            _cardAtkText.text = ud.Atk.ToString();
            _cardDefText.text = ud.Def.ToString();
            gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().material = _unitMaterial;
        }

        //if spell card, need to change card material as well as hide atk / def
        SpellData sd = _data as SpellData;
        if(sd != null)
        {
            _cardAtkText.enabled = false;
            _cardDefText.enabled = false;
            //need to deactivate the borders as well
            gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().material = _spellMaterial;
        }
    }
}
