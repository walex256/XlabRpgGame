using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    [SerializeField] private Transform[] m_spawmPoints;
    [SerializeField] private EnemyData[] m_data;
    [SerializeField] private Enemy[] m_enemies;

    private List<Enemy> m_currentEnemies = new();
    public void Spawn()
    {
        var factory = ServiceLocator.Resolve<IPlayerFactorySettings>();
        factory.position = Vector3.negativeInfinity;
        var playerTransform = ServiceLocator.Resolve<IPlayerFactory>().Create().transform;
        foreach (var spawnPoint in m_spawmPoints)
        {
            var enemy = GetEnemy();
            var enemyData = GetEnemyData();
            var enemyInstance = Instantiate(enemy, spawnPoint);
            enemyInstance.Initialize(enemyData, playerTransform);
            enemyInstance.Died += OnDied;
            m_currentEnemies.Add(enemyInstance);
        }
    }
    private Enemy GetEnemy() => m_enemies[Random.Range(0, m_enemies.Length)];
    private Enemy GetEnemyData() => m_enemies[Random.Range(0, m_data.Length)];
    public void DespawnAll()
    {
        foreach (var enemy in m_currentEnemies)
        {
            DestroyEnemy(enemy);
        }
        m_currentEnemies.Clear();
    }
    private void OnDied(Enemy enemy)
    {
        m_currentEnemies.Remove(enemy);
        DestroyEnemy(enemy);
    }
    private void DestroyEnemy(Enemy enemy)
    {
        if (enemy)
        {
            enemy.Died -= OnDied;
            Destroy(enemy.gameObject);
        }
    }
}
