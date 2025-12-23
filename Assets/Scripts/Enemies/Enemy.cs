using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private HealthComponent m_healthComponent;
    private EnemyData m_data;

    private void OnEnable()
    {
        m_healthComponent.ValueChanged += () =>
        {
            Debug.Log($"Health Changed:{m_healthComponent.Value}");
        };
    }
    private void OnDisable()
    {
        m_healthComponent.Died -= OnDied;
    }

    private void OnDied()
    {
        Debug.Log("EnemyDied");
        Destroy(gameObject);
    }

    public void Initialize(EnemyData data)
   {
        m_data = data;
        m_healthComponent.Initialize(data.health);
   }
}
