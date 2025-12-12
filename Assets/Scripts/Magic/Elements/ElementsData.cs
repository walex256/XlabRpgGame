using System.Collections.Generic;
using UnityEngine;

public sealed class ElementsData : ScriptableObject
{
    [SerializeField] private Item[] m_items;
    public IReadOnlyList<Item> Items => m_items;
    [SerializeField]
    public sealed class Item
    {
        [SerializeField] private string m_elementName;
        [SerializeField] private ElementType m_elementType;
        [SerializeField] private Sprite m_icon;

        public Sprite icon => m_icon;

        public ElementType type => m_elementType;

        public string name => m_elementName;
    }
}
