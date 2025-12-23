using UnityEngine;
[CreateAssetMenu(fileName = "EnemyData")]
public class EnemyData : ScriptableObject
{
    [SerializeField][Min(0)] private float m_health;
    [SerializeField][Range (0f,100f)] private float m_speed;
    [SerializeField][Min(0)] private float m_ataackTime;
    [SerializeField] private AttackEnemyType m_attackEnemyType;
    [SerializeField][Min(0)] private float m_attackRange;

    public float health => m_health;
    public float speed => m_speed;
    public float ataackTime => m_ataackTime;
    public float attackRange => m_attackRange;

}
public enum AttackEnemyType
{
    Range,
    Melee
}
