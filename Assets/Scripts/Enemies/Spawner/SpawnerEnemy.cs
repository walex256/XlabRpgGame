using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    [SerializeField] private Transform[] m_spawmPoints;
    [SerializeField] private EnemyData[] m_data;
    [SerializeField] private Enemy[] m_enemies;

    public void Spawn()
    {
        foreach (var spawnPoint in m_spawmPoints)
        {
            var enemy = GetEnemy();
            var enemyData = GetEnemyData();

            var  enemyInstance = Instantiate(enemy,spawnPoint);
            enemyInstance.Initialize(enemyData);
        }
    }
    private Enemy GetEnemy() => m_enemies[Random.Range(0, m_enemies.Length)];
    private Enemy GetEnemyData() => m_enemies[Random.Range(0, m_data.Length)];

}
