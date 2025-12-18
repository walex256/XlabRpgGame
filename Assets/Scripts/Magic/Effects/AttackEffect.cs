using UnityEngine;

public class AttackEffect : IEffect
{
    [SerializeField][Min(0f)] private float m_damage;

    public void Apply(IEffectable efffectable)
    {

    }
}
