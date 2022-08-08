using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] List<GameObject> enemyPrefabList;    // 生成オブジェクト
    float minX, maxX, minY, maxY;                   // 生成範囲

    int frame = 0;
    [SerializeField] int generateFrame = 30;        // 生成する間隔

    void Start()
    {
        minX = -10;
        maxX = 10;
        minY = -10;
        maxY = 10;
    }

    void Update()
    {
        ++frame;

        if (frame > generateFrame)
        {
            frame = 0;

            // ランダムで種類と位置を決める
            int index = Random.Range(0, enemyPrefabList.Count);
            float posX = Random.Range(minX, maxX);
            float posY = Random.Range(minY, maxY);

            Instantiate(enemyPrefabList[index], new Vector3(posX, posY, 0), Quaternion.identity);
        }
    }
}