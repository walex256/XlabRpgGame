using System;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public event Action<Enemy> Died;

    [SerializeField] private AttackEnemy m_attack;
    [SerializeField] private HealthComponent m_health;
    [SerializeField] private EnemyMovement m_movement;

    private EnemyData m_data;
    private Transform m_playerTransform;
    private EnemyStateMachine m_stateMachine;

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

   public void Initialize(EnemyData data, Transform playerTransform)
   {
        m_data = data;
        m_healthComponent.Initialize(data.health);
   }
}
