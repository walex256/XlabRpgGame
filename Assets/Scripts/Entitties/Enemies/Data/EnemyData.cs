using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "EnemyData")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private BaseSpellData m_spell;
    [SerializeField][Min(0)] private float m_health;
    [SerializeField][Range (0f,100f)] private float m_speed;
    [SerializeField][Min(0)] private float m_ataackTime;
    [SerializeField] private AttackEnemyType m_attackEnemyType;
    [SerializeField][Min(0)] private float m_attackRange;
    [SerializeField] private BaseSpellData m_defaultSpell;
    [SerializeField] private AttackEnemyType m_enemyType;
    [SerializeField] private SpellEnemyData[] m_spells;
    public float health => m_health;
    public float speed => m_speed;
    public float ataackTime => m_ataackTime;
    public float attackRange => m_attackRange;
    public AttackEnemyType enemyType => m_enemyType;

    public BaseSpellData defaultSpell => m_defaultSpell;

    public IReadOnlyList<SpellEnemyData> spells => m_spells;
}
public enum AttackEnemyType
{
    Range,
    Melee
}
[SerializeField]
public struct SpellEnemyData
{
    [SerializeField] public int count;
    [SerializeField] public BaseSpellData spell;

}
