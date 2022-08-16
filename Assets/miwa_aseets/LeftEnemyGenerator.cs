using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftEnemyGenerator : MonoBehaviour
{
    [SerializeField] List<GameObject> enemyList;    // 生成オブジェクト

    int frame = 0;
    [SerializeField] int generateFrame = 100;        // 生成する間隔

    void Start()
    {
    }

    void Update()
    {
        ++frame;
        Vector2 min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);

        if (frame > generateFrame)
        {
            frame = 0;

            // ランダムで種類と位置を決める
            int index = Random.Range(0, enemyList.Count);
            float posX = Random.Range(min.x - 2f , min.x - 1f);
            float posY = Random.Range(min.y - 1f , max.y + 1f);

            Instantiate(enemyList[index], new Vector3(posX, posY, 0), Quaternion.identity);
        }
    }
}