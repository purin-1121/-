using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpown : MonoBehaviour
{
    //通常の敵
    [Header("Normal Enemy")]
    public GameObject enemyPrefab;
    //敵の出現時間
    public float spawnInterval = 1.5f;
    //出現のY軸幅
    public float spawnYrange = 3.0f;
    //出現のX軸幅
    public float spawnXrange = 10.0f;

    //特殊な敵
    [Header("Special Enemy")]
    public GameObject specialPrefab;
    //敵の出現時間
    public float specialEnemyspawnInterval = 3.0f;
    //出現のY軸幅
    public float specialEnemyspawnYrange = 3.0f;
    //出現のX軸幅
    public float specialEnemyspawnXrange = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //敵の出現間隔
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnInterval);

        //敵の出現間隔
        InvokeRepeating(nameof(SpawnSpecialEnemy), 2f, specialEnemyspawnInterval);
    }

    // Update is called once per frame

    //スポーン処理
    void SpawnEnemy()
    {
        if (enemyPrefab == null) return;

        float y = Random.Range(-spawnYrange, spawnYrange);

        Vector3 position = new Vector3(spawnXrange, y, 0);

        Instantiate(enemyPrefab, position, Quaternion.identity);

        
    }

    //特殊な敵の出現処理
    void SpawnSpecialEnemy()
    {
        if (enemyPrefab == null) return;

        //敵のスポーンできる幅
        float Y = Random.Range(-specialEnemyspawnYrange, specialEnemyspawnYrange);

        //敵の出現地点
        Vector3 specialposition = new Vector3(specialEnemyspawnXrange, Y, 0);

        //
        Instantiate(specialPrefab, specialposition, Quaternion.identity);
    }
}
