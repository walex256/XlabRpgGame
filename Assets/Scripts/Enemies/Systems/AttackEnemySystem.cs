using UnityEngine;

public sealed class AttackEnemySystem : MonoBehaviour
{
    private Transform m_target;
    private BaseSpellData m_spell;
    private SpellCaster m_spellCaster;

    private float m_attackEnemy;
    private bool isInit;
    private float m_cooldownTimer;

    private void Initialize(BaseSpellData spell, float attacktime, Transform target)
    {
        m_spell = spell;
        m_attackEnemy = attacktime;
        m_target = target;
        m_spellCaster = new SpellCaster(transform);

        isInit = true;
    }

    private bool TryAttack()
    {
        if (isInit == false || m_target == false) return false;
        if (m_cooldownTimer > 0) { return false; }
            m_spellCaster.Cast(m_spell, m_target.position);
        return true;
    }

    private void Update()
    {
        if (!isInit)
        {
            return;
        }
        if (m_cooldownTimer > 0) { m_cooldownTimer -= Time.deltaTime; }
    }
}
