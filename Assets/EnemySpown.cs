using UnityEngine;

public class EnemySpown : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 1.5f;
    public float spawnYrange = 3.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
