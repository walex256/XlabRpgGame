using UnityEngine;
using UnityEngine.AI;

public class EnemyMovment : MonoBehaviour
{
    [SerializeField] private NavMeshAgent m_agent;

    private Transform m_target;
    private bool m_isMoving;
    private bool m_isInitialized;

    private void Initialize(float speed, Transform target)
    {
        m_target = target;
        m_agent.speed = speed;
        m_isInitialized = true;
    }
    private void Update()
    {
        if (m_isInitialized || !m_isMoving || !m_target)
        {
            return;
        }
        m_agent.SetDestination(m_target.position);
    }

   // public void 
}
