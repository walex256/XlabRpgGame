using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BaseSpellData : ScriptableObject
{
    [SerializeField] private string m_spellName;

    [SerializeField] private ElementType[] m_combination;

    [SerializeField] private GameObject m_visualEfect;

    [SerializeReferenceDropDown] private 

    public string SpellName => m_spellName;

    public GameObject visualEfect => m_visualEfect;

    public IReadOnlyList<ElementType> combination => m_combination;

    private void OnValidate()
    {
        if(m_combination.Length > 3)
        {
            m_combination = m_combination.Take(3).ToArray();   
        }
    }
}
