using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject enemyPrefab; // 敌人的预制体
    public float spawnRate = 2.0f; // 敌人的生成频率（以秒为单位）
    public Vector3 spawnAreaSize = new Vector3(18, 0, 2); // 敌人的生成区域大小
    public Vector3 spawnAreaCenter; // 生成区域的中心位置

    private void Start()
    {
        // 启动协程，以一定的频率生成敌人
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        // 这是一个无限循环，会持续生成敌人
        while (true)
        {
            // 计算一个随机的生成位置
            // 首先，根据spawnAreaSize计算x和z坐标的随机值
            float spawnPosX = Random.Range(-spawnAreaSize.x, spawnAreaSize.x) + spawnAreaCenter.x;
            float spawnPosZ = Random.Range(-spawnAreaSize.z, spawnAreaSize.z) + spawnAreaCenter.z;
            
            // 使用spawnAreaCenter的y坐标和spawnAreaSize的y分量来计算实际的y坐标
            float spawnPosY = spawnAreaSize.y + spawnAreaCenter.y;
            
            // 结合这些坐标来创建一个Vector3位置
            Vector3 spawnPosition = new Vector3(spawnPosX, spawnPosY, spawnPosZ);

            // 使用Instantiate函数创建一个新的敌人对象
            // 此处我们使用Quaternion.identity表示默认旋转（无旋转）
            Instantiate(enemyPrefab, spawnPosition, Quaternion.Euler(0, 180, 0));

            // WaitForSeconds是一个特殊的yield指令，它会等待指定的秒数
            // 在这种情况下，它将等待spawnRate秒，然后继续执行循环的下一次迭代
            yield return new WaitForSeconds(spawnRate);
        }
    }
}