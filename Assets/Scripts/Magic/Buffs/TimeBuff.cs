using System;
using UnityEngine;

public abstract class TimeBuff : BaseBuff
{
    [SerializeField] private float m_timer;
    [NonSerialized] private float m_duration;

    public override void OnDeinitializing() => m_timer = 0;

    public sealed override void Update(float dt)
    {
        if (m_timer > m_duration)
        {
            OnUpdate(dt);
            m_timer += dt;
        }
        else
        {
            Deinitialize();
        }
    }

    protected virtual void OnUpdate(float dt)
    {
        
    }
}
