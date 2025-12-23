using System;
using UnityEngine;
public class HealthComponent : MonoBehaviour, IHealth, IEffectable
{
    public event Action Died;
    public event Action ValueChanged;

    private float m_value;

    private bool m_initialized;

    public void Initialize(float value)
    {
        if (m_initialized)
        {
            throw new InvalidOperationException("bo");
        }
        m_value = value;
        m_initialized = true;
    }
    public float Value
    {
        get => m_value;

        private set
        {
            if (Mathf.Approximately( m_value , value))
            {
                return;
            }

            m_value = value<0 ? 0 : value;
            ValueChanged?.Invoke();
        }
    }

    public void Hael(float heal)
    {
        if (heal <0)
        {
            throw new ArgumentOutOfRangeException(nameof(heal),"Heal cannot negative");
        }
        Value += heal;
    }

    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(damage), "Damage cannot negative");
        }
        Value -= damage;
    }
}
